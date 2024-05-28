using Events;
using Godot;

public partial class Base_Scene<TModel> : Node2D
{
    public TModel Model { get; protected set; }

    public Base_Scene()
    {
        Game_Update_Event.Listen(Update);
    }

    public virtual void Update() { }
}
