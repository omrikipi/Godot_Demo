using Core;
using Models;

namespace Messages;

public record Start_Timer_Message(Timer_Model Model)
    : Message<Start_Timer_Message>()
{
}
