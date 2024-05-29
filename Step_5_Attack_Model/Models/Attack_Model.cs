using Commands;

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
}
