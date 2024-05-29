using Commands;

namespace Controllers;

public class Attack_Controller
{
    public Attack_Controller()
    {
        Attack_Command.Handle(Attack_Command_Handler);
    }

    private void Attack_Command_Handler(Attack_Command command)
    {
        command.Target.Hit(command.Model.Damage);
    }
}