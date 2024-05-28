namespace Interfaces;

public interface IEntity_Model
{
    /// <summary>
    /// The current attack model
    /// </summary>
    IAttack_Model Attack_Model { get; }

    /// <summary>
    /// How much hp the entity have
    /// </summary>
    int Hp { get; set; }
    
    /// <summary>
    /// Is the hp is larger then zero
    /// </summary>
    bool Is_Alive => Hp > 0;
}
