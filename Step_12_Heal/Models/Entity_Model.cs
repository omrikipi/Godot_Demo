using System.Linq;
using Commands;
using Resources;

namespace Models;

public class Entity_Model
{
    public int Max_Hp { get; set; }
    public int Hp { get; set; }
    public Action_Model[] Actions { get; }
    public bool Is_Alive => Hp > 0;

    public Entity_Model(Entity_Resource resource)
    {
        Max_Hp = resource.Hp;
        Hp = resource.Hp;
        Actions = resource.Actions
            .Select(Get_Model)
            .ToArray();
    }

    public void Hit(int damage)
    {
        new Hp_Change_Command(this, -damage);
    }

    public void Heal(int amount)
    {
        new Hp_Change_Command(this, amount);
    }

    private Action_Model Get_Model(Action_Resource resource)
    {
        if (resource is Dot_Resource)
            return new Dot_Attack_Model(this, resource as Dot_Resource);
        if (resource is Attack_Resource)
            return new Attack_Model(this, resource as Attack_Resource);
        if (resource is Heal_Resource)
            return new Heal_Model(this, resource as Heal_Resource);
        return null;
    }
}
