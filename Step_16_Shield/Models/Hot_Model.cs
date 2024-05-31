using Commands;
using Interfaces;
using Resources;

namespace Models;

public class Hot_Model : Heal_Model, IOver_Time_Model
{
    public int Time_Between { get; }
    public int Times { get; }

    public Hot_Model(IEntity_Model owner, Hot_Resource resource)
        : base(owner, resource)
    {
        Time_Between = resource.Time_Between;
        Times = resource.Times;
    }

    public override void Do(IEntity_Model enemy)
    {
        new Over_Time_Command(this, enemy);
    }
}