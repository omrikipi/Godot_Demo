using System.Linq;
using Commands;
using Resources;

namespace Models;

public class Entity_Model
{
    public int Hp { get; set; }
    public Action_Model[] Actions { get; }
    public bool Is_Alive => Hp > 0;

    public Entity_Model(Entity_Resource resource)
    {
        Hp = resource.Hp;
        Actions = resource.Actions
            .Select(Get_Model)
            .ToArray();
    }

    public void Hit(int damage)
    {
        new Hit_Command(this, damage);
    }

    private Action_Model Get_Model(Action_Resource resource)
    {
        if (resource is Dot_Resource)
            return new Dot_Attack_Model(this, resource as Dot_Resource);
        if (resource is Attack_Resource)
            return new Attack_Model(this, resource as Attack_Resource);
        return null;
    }
}
