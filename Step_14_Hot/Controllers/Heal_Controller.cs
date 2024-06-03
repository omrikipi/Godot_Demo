using Commands;
using Messages;

namespace Controllers;

public class Heal_Controller : Action_Controller
{
    public Heal_Controller()
    {
        Heal_Command.Handler = Heal_Command_Handler;
        Can_Heal_Request.Handler = Can_Heal_Request_Handler;
    }

    private bool Can_Heal_Request_Handler(Can_Heal_Request request)
    {
        return Can_Action(request.Model, request.Target);
    }

    private void Heal_Command_Handler(Heal_Command command)
    {
        command.Model.Cooldown.Start();
        command.Target.Hp.Value += command.Model.Heal;
    }
}