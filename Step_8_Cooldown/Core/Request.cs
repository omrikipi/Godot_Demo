using System;

namespace Core;

public abstract record Request<TRequest, TResult> : Base
    where TRequest : class
{
    public static Func<TRequest, TResult> Handler;

    public TResult Send()
    {
        Started();
        var reqeust = this as TRequest;
        var result = Handler(reqeust);
        Ended();
        return result;
    }
}