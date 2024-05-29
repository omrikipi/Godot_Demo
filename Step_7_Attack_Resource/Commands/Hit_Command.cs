using Core;
using Models;

namespace Commands;

public record Hit_Command(Entity_Model Model, int Damge)
    : Command<Entity_Model, Hit_Command>(Model)
{
}
