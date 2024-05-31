using Commands;
using Messages;
using Models;

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
        return Can_Attack(request.Attack, request.Target);
    }

    private void Attack_Command_Handler(Attack_Command command)
    {
        if (Can_Attack(command.Model, command.Target))
        {
            command.Model.Cooldown.Start();
            command.Target.Hit(command.Model.Damage);
        }
    }

    private bool Can_Attack(Attack_Model attack, Entity_Model target)
    {
        return target.Is_Alive & attack.Owner.Is_Alive & attack.Cooldown.Ended;
    }
}