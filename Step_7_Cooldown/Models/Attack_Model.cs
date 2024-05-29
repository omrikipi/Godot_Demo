using Commands;
using Messages;

namespace Models;

public class Attack_Model
{
    private readonly Entity_Model owner;

    public int Damage { get; set; }

    public Attack_Model(Entity_Model owner, Entity_Resource resource)
    {
        this.owner = owner;
        Damage = resource.Damage;
    }

    public void Attack(Entity_Model enemy)
    {
        new Attack_Command(owner, enemy);
    }

    public bool Can_Attack(Entity_Model enemy)
    {
        return new Can_Attack_Request(owner, enemy).Send();
    }
}