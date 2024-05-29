using System.Linq;
using Commands;
using Resources;

namespace Models;

public class Entity_Model
{
    public int Hp { get; set; }
    public Attack_Model[] Attacks { get; }
    public bool Is_Alive => Hp > 0;

    public Entity_Model(Entity_Resource resource)
    {
        Hp = resource.Hp;
        Attacks = resource.Attacks
            .Select(r => new Attack_Model(this, r))
            .ToArray();
    }

    public void Hit(int damage)
    {
        new Hit_Command(this, damage);
    }
}
