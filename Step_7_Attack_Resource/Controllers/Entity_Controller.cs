using System;
using Commands;
using Messages;

namespace Controllers;

public class Entity_Controller
{
    public Entity_Controller()
    {
        Hit_Command.Handle(Hit_Command_Handler);
    }

    private void Hit_Command_Handler(Hit_Command command)
    {
        command.Model.Hp = Math.Max(0, command.Model.Hp - command.Damge);
        new Update_Message();
    }
}
