using System;
using System.Collections.Generic;

namespace Core;

public abstract record Request<TRequest, TResult>
    where TRequest : class
{
    private static readonly List<Action<TRequest>> handlers = new();

    public TResult Send()
    {
        Console.WriteLine(GetType().Name + " started");
        var e = this as TRequest;
        foreach (var listener in handlers.ToArray())
            listener(e);
        Console.WriteLine(GetType().Name + " ended");
    }

    public static void Handle(Action<TRequest> listener)
    {
        if (!handlers.Contains(listener))
            handlers.Add(listener);
    }

    public static void Unhandle(Action<TRequest> listener)
    {
        if (handlers.Contains(listener))
            handlers.Remove(listener);
    }
}