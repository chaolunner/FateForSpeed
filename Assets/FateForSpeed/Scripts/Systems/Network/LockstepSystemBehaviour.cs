﻿using System.Collections.Generic;
using UniEasy.ECS;
using System;
using Common;
using UniRx;

public class LockstepSystemBehaviour : NetworkSystemBehaviour
{
    protected IGroup NetworkPlayerComponents;
    private Dictionary<int, int> tickIdDict = new Dictionary<int, int>();

    public override void Initialize(IEventSystem eventSystem, IPoolManager poolManager, GroupFactory groupFactory, PrefabFactory prefabFactory)
    {
        base.Initialize(eventSystem, poolManager, groupFactory, prefabFactory);
        NetworkPlayerComponents = this.Create(typeof(NetworkPlayerComponent));
    }

    public override void OnEnable()
    {
        base.OnEnable();
        LockstepUtility.OnRestart += OnRestart;

        NetworkPlayerComponents.OnAdd().Subscribe(entity =>
        {
            var networkPlayerComponent = entity.GetComponent<NetworkPlayerComponent>();
            IInput[] inputs;

            Observable.EveryUpdate().Subscribe(_ =>
            {
                if (networkPlayerComponent.IsLocalPlayer)
                {
                    inputs = UpdateInputs();
                    if (inputs != null && inputs.Length > 0)
                    {
                        for (int i = 0; i < inputs.Length; i++)
                        {
                            LockstepUtility.AddInput(inputs[i]);
                        }
                    }
                }

                UpdateTimeline(entity);
            }).AddTo(this.Disposer).AddTo(networkPlayerComponent.Disposer);
        }).AddTo(this.Disposer);
    }

    public virtual IInput[] UpdateInputs() { return null; }

    public virtual void UpdateTimeline(IEntity entity) { }

    public void PushUntilLastStep(IEntity entity, params Type[] inputTypes)
    {
        var networkPlayerComponent = entity.GetComponent<NetworkPlayerComponent>();
        var userId = networkPlayerComponent.UserId;
        if (!tickIdDict.ContainsKey(userId)) { tickIdDict.Add(userId, 0); }
        var tickId = tickIdDict[userId];
        if (inputTypes != null && inputTypes.Length > 0)
        {
            var inputType = inputTypes[0];
            var userInputData = LockstepUtility.GetUserInputData(tickId, userId, inputType);
            while (userInputData != null)
            {
                ApplyUserInput(entity, userInputData);
                for (int i = 1; i < inputTypes.Length; i++)
                {
                    ApplyUserInput(entity, LockstepUtility.GetUserInputData(tickId, userId, inputTypes[i]));
                }
                userInputData = LockstepUtility.GetUserInputData(++tickId, userId, inputType);
            }
        }
        tickIdDict[userId] = tickId;
    }

    public virtual void ApplyUserInput(IEntity entity, UserInputData userInputData) { }

    public virtual void OnRestart()
    {
        tickIdDict.Clear();
    }

    public override void OnDisable()
    {
        base.OnDisable();
        LockstepUtility.OnRestart -= OnRestart;
    }
}