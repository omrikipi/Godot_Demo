using System;
using Events;
using Interfaces;
using Resources;

namespace Models;

public class Hp_Model : IHp_Model
{
    public int Value { get; private set; }
    public int Armor { get; }

    public Hp_Model(Entity_Resource resource)
    {
        Value = resource.Hp;
        Armor = resource.Armor;
    }

    public void Reduce(int amount)
    {
        if (amount <= 0)
            return;
        amount = Math.Max(1, amount - Armor);
        Value = Math.Max(0, Value - amount);
        Game_Update_Event.Invoke();
    }
}
