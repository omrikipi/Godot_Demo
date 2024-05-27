using System;
using System.Collections.Generic;

namespace Core;

public abstract class Event<TEvent>
{
    private static readonly List<Action> listeners = new();

    public static void Invoke()
    {
        foreach (var listener in listeners.ToArray())
            listener();
    }

    public static void Listen(Action listener)
    {
        if (!listeners.Contains(listener))
            listeners.Add(listener);
    }

    public static void Unlisten(Action listener)
    {
        if (listeners.Contains(listener))
            listeners.Remove(listener);
    }
}