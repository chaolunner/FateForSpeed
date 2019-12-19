﻿using UniEasy.ECS;
using System;

public static class INetworkTimelineExtensions
{
    public static IDisposable OnForward(this INetworkTimeline timeline, Func<IEntity, UserInputData[], float, IUserInputResult[]> onNext)
    {
        Func<ForwardTimelineData, IUserInputResult[]> func = data =>
        {
            return onNext(data.Entity, data.UserInputData, data.DeltaTime);
        };
        return timeline.OnForward(func);
    }

    public static IDisposable OnReverse(this INetworkTimeline timeline, Action<IEntity, IUserInputResult[]> onNext)
    {
        Action<ReverseTimelineData> action = data =>
        {
            onNext(data.Entity, data.UserInputResult);
        };
        return timeline.OnReverse(action);
    }
}