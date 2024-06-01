namespace Interfaces;

public interface IAction_Model
{
    IEntity_Model Owner { get; }
    ITimer_Model Cooldown { get; }
    string Name { get; }

    void Do(IEntity_Model enemy);
    bool Can_Do(IEntity_Model enemy);
}