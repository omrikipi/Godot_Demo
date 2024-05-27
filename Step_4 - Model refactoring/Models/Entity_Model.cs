using System;
using Events;
using Resources;

namespace Models;

public class Entity_Model
{
    public int Hp { get; private set; }

    public int Damge { get; }


    public bool Is_Alive => Hp > 0;

    public Entity_Model(Entity_Resource resource)
    {
        Hp = resource.Hp;
        Damge = resource.Damge;
    }

    public void Hit(Entity_Model enemy)
    {
        if (Is_Alive & enemy.Is_Alive)
        {
            enemy.Hp = Math.Max(0, enemy.Hp - Damge);
            Game_Update.Invoke();
        }
    }
}
