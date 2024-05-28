using System;
using Events;
using Resources;

namespace Models;

public class Entity_Model
{
    public readonly Attack_Model Attack_Model;
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
                Game_Update_Event.Invoke();
            }
        }
    }

    public Entity_Model(Entity_Resource resource)
    {
        hp = resource.Hp;
        Attack_Model = new Attack_Model(this, resource.Attack);
    }
}
