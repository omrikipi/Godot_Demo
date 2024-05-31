using Core;
using Models;

namespace Commands;

public record Hp_Change_Command(Entity_Model Model, int Amount)
    : Command<Entity_Model, Hp_Change_Command>(Model)
{
}
