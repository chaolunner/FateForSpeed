﻿using UniEasy.ECS;
using Common;
using UniRx;

public class LockstepSystem : NetworkSystemBehaviour
{
    public override void OnEnable()
    {
        base.OnEnable();

        NetworkSystem.Receive<string>(RequestCode.Input).Subscribe(data =>
        {
        }).AddTo(this.Disposer);

        NetworkSystem.Receive<byte[]>(RequestCode.Lockstep).Subscribe(dataBytes =>
        {
            LockstepInputs lockstepInputs = MessagePackUtility.Deserialize<LockstepInputs>(dataBytes);
            LockstepUtility.AddToTimeline(lockstepInputs);
        }).AddTo(this.Disposer);
    }

    private void Update()
    {
        UserInputs userInputs = LockstepUtility.GetUserInputs();
        byte[] dataBytes = MessagePackUtility.Serialize(userInputs);
        NetworkSystem.Publish(RequestCode.Input, dataBytes);
    }

    public override void OnDisable()
    {
        base.OnDisable();
    }
}
