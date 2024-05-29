using Core;
using Models;

namespace Commands;

public record Attack_Command(Entity_Model Model, Entity_Model Enemy)
    : Command<Entity_Model, Attack_Command>(Model)
{
}
