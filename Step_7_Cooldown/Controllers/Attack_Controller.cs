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
        return Can_Attack(request.Attacker, request.Enemy);
    }

    private void Attack_Command_Handler(Attack_Command command)
    {
        if (Can_Attack(command.Model, command.Enemy))
            command.Enemy.Hit(command.Model.Attack_Model.Damage);
    }

    private bool Can_Attack(Entity_Model attacker, Entity_Model enemy)
    {
        return enemy.Is_Alive & attacker.Is_Alive;
    }
}