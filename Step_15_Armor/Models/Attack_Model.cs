using Commands;
using Interfaces;
using Messages;
using Resources;

namespace Models;

public class Attack_Model : Action_Model
{
    public int Damage { get; }

    public Attack_Model(IEntity_Model owner, Attack_Resource resource)
    : base(owner, resource)
    {
        Damage = resource.Damage;
    }

    public override void Do(IEntity_Model target)
    {
        new Attack_Command(this, target);
    }

    public override bool Can_Do(IEntity_Model target)
    {
        return new Can_Attack_Request(this, target).Result;
    }
}