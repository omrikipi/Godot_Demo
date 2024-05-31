using Core;
using Interfaces;
using Models;

namespace Commands;

public record Heal_Command(Heal_Model Model, IEntity_Model Target)
    : Command<Heal_Model, Heal_Command>(Model)
{
}