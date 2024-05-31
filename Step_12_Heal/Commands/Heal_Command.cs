using Core;
using Models;

namespace Commands;

public record Heal_Command(Heal_Model Model, Entity_Model Target)
    : Command<Heal_Model, Heal_Command>(Model)
{
}