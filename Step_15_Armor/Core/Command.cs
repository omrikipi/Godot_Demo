using System;
using Messages;

namespace Core;

public abstract record Command<TCommand> : Command_Base
    where TCommand : class
{
    public static Action<TCommand> Handler;

    public Command(bool update_message = true)
    {
        Started();
        ind++;
        Handler(this as TCommand);
        ind--;
        if (ind == 0 & update_message)
            new Update_Message();
        Ended();
    }
}