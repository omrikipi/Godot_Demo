using System.Collections.Generic;
using Core;
using Interfaces;
using Resources;

namespace Models;

public class Entity_Model : IEntity_Model
{
    public Range_Property<int> Hp { get; set; }
    public List<IAction_Model> Actions { get; }
    public int Armor { get; }
    public Range_Property<int> Shield { get; set; }

    public Entity_Model(Entity_Resource resource)
    {
        Hp = new Range_Property<int>(resource.Hp, 0, resource.Hp);
        Shield = new Range_Property<int>(0, 0, 0);
        Armor = resource.Armor;
        Actions = new();
    }
}
