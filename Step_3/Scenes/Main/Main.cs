using Events;
using Godot;

public partial class Main : Node2D
{
    public override void _Ready()
    {
        base._Ready();
        Game_Update.Invoke();
    }
}
