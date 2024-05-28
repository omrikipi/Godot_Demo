namespace Interfaces;

public interface IAttack_Model
{
    /// <summary>
    /// Attack the entity if Can_Attack(enemy)
    /// </summary>
    /// <param name="enemy"></param>
    void Hit(IEntity_Model enemy);

    /// <summary>
    /// Can the attack model attack the entity
    /// </summary>
    /// <param name="enemy"></param>
    /// <returns></returns>
    bool Can_Attack(IEntity_Model enemy);
}
