using Core;
using Interfaces;

namespace Messages;

public record Start_Timer_Message(ITimer_Model Model)
    : Message<Start_Timer_Message>()
{
}