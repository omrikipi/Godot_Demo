using Core;
using Interfaces;
using Models;

namespace Commands;

public record Attack_Command(Attack_Model Model, IEntity_Model Target)
    : Command<Attack_Model, Attack_Command>(Model)
{
}
