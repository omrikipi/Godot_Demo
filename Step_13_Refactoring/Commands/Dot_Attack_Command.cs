using Core;
using Interfaces;
using Models;

namespace Commands;

public record Dot_Attack_Command(Dot_Attack_Model Model, IEntity_Model Target)
    : Command<Dot_Attack_Model, Dot_Attack_Command>(Model)
{
    public int Activated { get; set; }
}
