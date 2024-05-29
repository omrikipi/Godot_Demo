using System;

namespace Core;

public abstract record Base
{
    private static int ind = 0;

    protected virtual void Started()
    {
        Write_log("Started");
        ind++;
    }

    protected virtual void Ended()
    {
        ind--;
        Write_log("Ended");
    }

    protected void Write_log(string message)
    {
        var time = DateTime.Now.ToString("HH:mm:ss");
        for (int i = 0; i < ind; i++)
            time += '\t';
        Console.WriteLine($"{time} {GetType().Name} {message}");
    }
}