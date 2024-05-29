using System;

namespace Core;

public abstract record Request<TRequest, TResult>
    where TRequest : class
{
    public static Func<TRequest, TResult> Handler;

    public TResult Send()
    {
        Console.WriteLine(GetType().Name + " started");
        var reqeust = this as TRequest;
        var result = Handler(reqeust);
        Console.WriteLine(GetType().Name + " ended");
        return result;
    }
}