using System;
using Commands;
using Messages;

namespace Controllers;

public class Entity_Controller
{
    public Entity_Controller()
    {
        Hp_Change_Command.Handle(Hp_Change_Command_Handler);
    }

    private void Hp_Change_Command_Handler(Hp_Change_Command command)
    {
        command.Model.Hp = Math.Min(command.Model.Max_Hp, Math.Max(0, command.Model.Hp + command.Amount));
        new Update_Message();
    }
}
