using Core;
using Models;

namespace Commands;

public record Reset_Cooldown_Command(Cooldown_Model Model)
    : Command<Cooldown_Model, Reset_Cooldown_Command>(Model)
{
}
