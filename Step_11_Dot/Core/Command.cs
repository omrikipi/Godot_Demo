namespace Core;

public record class Command<TModel, TCommand>(TModel Model) : Message<TCommand>
    where TCommand : class
{
}