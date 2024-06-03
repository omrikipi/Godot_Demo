using Commands;
using Interfaces;
using Messages;
using Resources;

namespace Models;

public class Heal_Model : Action_Model, IAmount_Model
{
    public int Amount { get; }

    public Heal_Model(IEntity_Model owner, Heal_Resource resource) :
        base(owner, resource)
    {
        Amount = resource.Heal;
    }

    public override void Do(IEntity_Model enemy)
    {
        new Heal_Command(this, enemy);
    }

    public override bool Can_Do(IEntity_Model target)
    {
        return new Can_Heal_Request(this, target).Result;
    }
}