using Core;
using Models;

namespace Messages;

public record Can_Attack_Request(Entity_Model Attacker, Entity_Model Enemy)
    : Request<Can_Attack_Request, bool>
{
}
