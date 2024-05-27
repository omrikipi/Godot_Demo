using System;
using System.Linq;
using Events;
using Interfaces;
using Resources;

namespace Models;

public class Entity_Model : IEntity_Model
{
    public IAttack_Model[] Attack_Models { get; }
    private int hp;

    public int Hp
    {
        get => hp;
        set
        {
            if (hp != value)
            {
                hp = Math.Max(0, value);
                Game_Update_Event.Invoke();
            }
        }
    }

    public Entity_Model(Entity_Resource resource)
    {
        hp = resource.Hp;
        Attack_Models = resource.Attacks
            .Select(r => new Attack_Model(this, r))
            .ToArray();
    }
}
