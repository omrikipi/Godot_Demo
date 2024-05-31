using Core;
using Interfaces;

namespace Commands;

public record Over_Time_Command(IOver_Time_Model Model, IEntity_Model Target) :
    Command<IOver_Time_Model, Over_Time_Command>(Model)
{
    public int Activated { get; set; }

    public virtual bool Equals(Over_Time_Command? other)
    {
        if (other is null) return false;
        return Target == other.Target & Model.Name == other.Model.Name;
    }

    public override int GetHashCode()
    {
        return Target.GetHashCode() + Model.Name.GetHashCode();
    }
}
