using Core;
using Interfaces;

namespace Commands;

public record Damage_Command(IEntity_Model Model, int Amount)
    : Command<IEntity_Model, Damage_Command>(Model)
{
}
