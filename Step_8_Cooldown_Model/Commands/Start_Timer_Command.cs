using Core;
using Models;

namespace Commands;

public record Start_Timer_Command(Timer_Model Model)
    : Command<Timer_Model, Start_Timer_Command>(Model)
{
}
