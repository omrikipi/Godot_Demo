using System.Collections.Generic;
using Commands;
using Messages;
using Models;

namespace Controllers;

public class Dot_Attack_Controller
{
    private readonly Dictionary<Timer_Model, Dot_Attack_Command> timers_to_models;

    public Dot_Attack_Controller()
    {
        timers_to_models = new();
        Dot_Attack_Command.Handle(Dot_Attack_Command_Handler);
        Update_Message.Handle(Update_Message_Handler);
    }

    private void Dot_Attack_Command_Handler(Dot_Attack_Command command)
    {
        var timer = new Timer_Model(command.Model.Time_Between);
        timers_to_models[timer] = command;
        command.Model.Cooldown.Start();
        Dot_Attack(timer, command);
    }

    private void Update_Message_Handler(Update_Message message)
    {
        foreach (var timer in timers_to_models.Keys)
            if (timer.Ended)
                Dot_Attack(timer, timers_to_models[timer]);
    }

    private void Dot_Attack(Timer_Model timer, Dot_Attack_Command cmd)
    {
        if (Can_Attack(cmd))
        {
            if (cmd.Activated++ < cmd.Model.Times - 1)
                timer.Start();
            else
                timers_to_models.Remove(timer);
            cmd.Target.Hit(cmd.Model.Damage);
        }
        else
            timers_to_models.Remove(timer);
    }

    private static bool Can_Attack(Dot_Attack_Command cmd)
    {
        return cmd.Target.Is_Alive;
    }
}