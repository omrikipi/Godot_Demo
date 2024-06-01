using Messages;

namespace Core;

public abstract record Command<TCommand> : Message<TCommand>
    where TCommand : class
{
    private static bool in_command;

    public Command()
    {
        new Update_Message();
    }
}