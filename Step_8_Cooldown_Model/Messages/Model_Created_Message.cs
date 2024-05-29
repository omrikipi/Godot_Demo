using Core;

namespace Messages;

public record Model_Created_Message<TModel>(TModel Model)
    : Message<Model_Created_Message<TModel>>
{
}
