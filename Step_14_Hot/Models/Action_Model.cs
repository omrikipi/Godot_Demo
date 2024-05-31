using Interfaces;
using Resources;

namespace Models;

public abstract class Action_Model : IAction_Model
{
    public IEntity_Model Owner { get; }
    public ITimer_Model Cooldown { get; }
    public string Name { get; }

    public Action_Model(IEntity_Model owner, Action_Resource resource)
    {
        Owner = owner;
        Name = resource.Name;
        Cooldown = new Timer_Model(resource.Cooldown);
    }

    public abstract void Do(IEntity_Model enemy);

    public abstract bool Can_Do(IEntity_Model enemy);
}