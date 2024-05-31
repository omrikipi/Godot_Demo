namespace Interfaces;

public interface IAction_Model
{
    public IEntity_Model Owner { get; }
    public ITimer_Model Cooldown { get; }
    public string Name { get; }

    void Do(IEntity_Model enemy);
    bool Can_Do(IEntity_Model enemy);
}