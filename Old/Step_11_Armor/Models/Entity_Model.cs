using System.Linq;
using Interfaces;
using Resources;

namespace Models;

public class Entity_Model : IEntity_Model
{
    public IAttack_Model[] Attacks { get; }

    public IHp_Model Hp { get; }

    public Entity_Model(Entity_Resource resource)
    {
        Hp = new Hp_Model(resource);
        Attacks = resource.Attacks
            .Select(r => new Attack_Model(this, r))
            .ToArray();
    }
}
