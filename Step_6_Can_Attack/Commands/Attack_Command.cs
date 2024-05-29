using Core;
using Models;

namespace Commands;

public record Attack_Command(Attack_Model Model, Entity_Model Target)
    : Command<Attack_Model, Attack_Command>(Model)
{
}
