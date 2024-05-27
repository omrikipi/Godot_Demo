using System;
using Events;
using Resources;

namespace Models;

public class Entity_Model
{
    private readonly Attack_Model attack;
    private int hp;

    public bool Is_Alive => Hp > 0;

    public int Hp
    {
        get => hp;
        set
        {
            if (hp != value)
            {
                hp = Math.Max(0, value);
                Game_Update.Invoke();
            }
        }
    }

    public Entity_Model(Entity_Resource resource)
    {
        hp = resource.Hp;
        attack = new Attack_Model(this, resource.Attack);
    }

    public void Hit(Entity_Model enemy)
    {
        attack.Hit(enemy);
    }
}
