using Commands;

namespace Models;

public class Attack_Model
{
    public Entity_Model Owner { get; }
    public int Damage { get; }

    public Attack_Model(Entity_Model owner, Entity_Resource resource)
    {
        Owner = owner;
        Damage = resource.Damage;
    }

    public void Attack(Entity_Model target)
    {
        new Attack_Command(this, target);
    }
}
