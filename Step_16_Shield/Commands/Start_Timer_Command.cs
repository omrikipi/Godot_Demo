using Core;
using Models;

namespace Commands;

public record Start_Timer_Command(Timer_Model Model)
    : Command<Start_Timer_Command>(false)
{
}
