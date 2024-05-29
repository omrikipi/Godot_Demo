using System.Collections.Generic;
using Commands;
using Godot;
using Messages;
using Models;

namespace Controllers;

public partial class Cooldown_Controller : Node
{
    private readonly List<Cooldown_Model> models;

    public Cooldown_Controller()
    {
        models = new List<Cooldown_Model>();
        Model_Created_Message<Cooldown_Model>.Handle(msg => models.Add(msg.Model));
        Reset_Cooldown_Command.Handle(Reset_Cooldown_Command_Handler);
        Time_Message.Handle(Time_Message_Handler);
    }

    private void Reset_Cooldown_Command_Handler(Reset_Cooldown_Command command)
    {
        models.Add(command.Model);
        command.Model.Current = command.Model.Cooldown;
    }

    private void Time_Message_Handler(Time_Message message)
    {
        for (int i = 0; i < models.Count; i++)
        {
            models[i].Current -= message.Delta;
            if (!models[i].Is_On)
            {
                new Update_Message();
                models.RemoveAt(i);
                i--;
            }
        }
    }
}