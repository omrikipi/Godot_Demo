using System;
using System.Collections.Generic;

namespace Core;

public abstract class Event<TEvent, TData>
{
    private static readonly List<Action<TData>> listeners = new();

    public static void Invoke(TData data)
    {
        foreach (var listener in listeners.ToArray())
            listener(data);
    }

    public static void Listen(Action<TData> listener)
    {
        if (!listeners.Contains(listener))
            listeners.Add(listener);
    }

    public static void Unlisten(Action<TData> listener)
    {
        if (listeners.Contains(listener))
            listeners.Remove(listener);
    }
}