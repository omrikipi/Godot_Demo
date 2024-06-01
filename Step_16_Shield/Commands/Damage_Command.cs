using Core;
using Interfaces;

namespace Commands;

public record Damage_Command(IHp_Model Model, int Amount)
    : Message<Damage_Command>()
{
}
