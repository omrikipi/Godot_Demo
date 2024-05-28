using Events;
using Godot;

public partial class Base_Scene<T> : Node2D
{
    public T Model;

    public Base_Scene()
    {
        Game_Update.Listen(Update);
    }

    public virtual void Update() { }
}
