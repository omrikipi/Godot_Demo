namespace Interfaces;

public interface IEntity_Model
{
    /// <summary>
    /// All the entity attacks
    /// </summary>
    IAttack_Model[] Attacks { get; }

    /// <summary>
    /// The hp model of the entity
    /// </summary>
    IHp_Model Hp { get; }

    /// <summary>
    /// Is the hp is larger then zero
    /// </summary>
    bool Is_Alive => Hp.Value > 0;
}
