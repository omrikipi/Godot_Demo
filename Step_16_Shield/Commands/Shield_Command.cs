using Core;
using Interfaces;
using Models;

namespace Commands;

public record Shield_Command(Shield_Model Model, IEntity_Model Target)
    : Command<Shield_Model, Shield_Command>(Model)
{
}