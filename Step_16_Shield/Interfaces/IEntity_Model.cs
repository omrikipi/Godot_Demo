using System.Collections.Generic;
using Core;

namespace Interfaces;

public interface IEntity_Model
{
    /// <summary>
    /// The hp of the entity, in a range of zero to max
    /// </summary>
    Range_Property<int> Hp { get; set; }

    /// <summary>
    /// All the actions that the entity can proforme
    /// </summary>
    List<IAction_Model> Actions { get; }

    /// <summary>
    /// The amount of damage reduction
    /// </summary>
    int Armor { get; }

    /// <summary>
    /// The amount of shield that takes damage (without armor reduction) before the hp is reduce
    /// </summary>
    Range_Property<int> Shield { get; set; }

    /// <summary>
    /// Is the entity have more then 0 hp
    /// </summary>
    bool Is_Alive => Hp.Value > 0;
}