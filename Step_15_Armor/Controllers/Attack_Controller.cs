using Commands;
using Messages;

namespace Controllers;

public class Attack_Controller
{
    public Attack_Controller()
    {
        Attack_Command.Handle(Attack_Command_Handler);
        Can_Attack_Request.Handler = Can_Attack_Request_Handler;
    }

    private bool Can_Attack_Request_Handler(Can_Attack_Request request)
    {
        return request.Target != null &&
            request.Target.Is_Alive &
            request.Model.Owner.Is_Alive &
            !request.Model.Cooldown.In_Progress;
    }

    private void Attack_Command_Handler(Attack_Command command)
    {
        command.Model.Cooldown.Start();
        new Damage_Command(command.Target, command.Model.Damage);
    }
}