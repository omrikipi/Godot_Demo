using Commands;
using Interfaces;
using Messages;
using Resources;

namespace Models;

public class Shield_Model : Action_Model
{
    public int Amount { get; }

    public Shield_Model(IEntity_Model owner, Shield_Resource resource)
    : base(owner, resource)
    {
        Amount = resource.Amount;
    }

    public override void Do(IEntity_Model target)
    {
        if (Can_Do(target))
            new Shield_Command(this, target);
    }

    public override bool Can_Do(IEntity_Model target)
    {
        return new Can_Heal_Request(this, target).Result;
    }
}