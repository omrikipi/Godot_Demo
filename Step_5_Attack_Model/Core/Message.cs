using System;
using System.Collections.Generic;

namespace Core;

public abstract record Message<TMessage>
    where TMessage : class
{
    private static readonly List<Action<TMessage>> handlers = new();

    public Message()
    {
        Console.WriteLine(GetType().Name + " started");
        var e = this as TMessage;
        foreach (var listener in handlers.ToArray())
            listener(e);
        Console.WriteLine(GetType().Name + " ended");
    }

    public static void Handle(Action<TMessage> listener)
    {
        if (!handlers.Contains(listener))
            handlers.Add(listener);
    }

    public static void Unhandle(Action<TMessage> listener)
    {
        if (handlers.Contains(listener))
            handlers.Remove(listener);
    }
}