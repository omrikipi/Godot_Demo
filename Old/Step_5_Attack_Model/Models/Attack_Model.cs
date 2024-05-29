using Resources;

namespace Models;

public class Attack_Model
{
    public int Damge { get; }

    private int cooldown { get; }

    private readonly Entity_Model owner;

    public Attack_Model(Entity_Model owner, Attack_Resource resource)
    {
        Damge = resource.Damge;
        this.owner = owner;
    }

    public void Hit(Entity_Model enemy)
    {
        if (owner.Is_Alive & enemy.Is_Alive)
            enemy.Hp -= Damge;
    }
}
