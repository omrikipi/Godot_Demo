using System;
using Commands;
using Messages;

namespace Controllers;

public class Heal_Controller
{
    public Heal_Controller()
    {
        Can_Heal_Request.Handler = Can_Heal_Request_Handler;
        Heal_Command.Handle(Heal_Command_Handler);
        Shield_Command.Handle(Shield_Command_Handler);
    }

    private bool Can_Heal_Request_Handler(Can_Heal_Request request)
    {
        return request.Target != null &&
            request.Target.Is_Alive &
            request.Model.Owner.Is_Alive &
            !request.Model.Cooldown.In_Progress;
    }

    private void Heal_Command_Handler(Heal_Command command)
    {
        command.Model.Cooldown.Start();
        command.Target.Hp.Value += command.Model.Heal;
    }

    private void Shield_Command_Handler(Shield_Command command)
    {
        command.Model.Cooldown.Start();
        command.Target.Shield.Max.Value = command.Model.Amount;
        command.Target.Shield.Value = command.Model.Amount;
        new Update_Message();
    }
}