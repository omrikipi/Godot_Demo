using Core;
using Interfaces;

namespace Commands;

public record Start_Timer_Command(ITimer_Model Model)
    : Command<ITimer_Model, Start_Timer_Command>(Model)
{
}
