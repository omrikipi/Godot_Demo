using Events;
using Godot;

public partial class Main : Node2D
{
    public override void _Ready()
    {
        base._Ready();
        Game_Update_Event.Invoke();
    }

    public override void _Process(double delta)
    {
        Game_Time_Event.Invoke(delta);
    }
}
