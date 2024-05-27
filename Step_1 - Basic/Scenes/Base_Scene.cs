using Godot;

public partial class Base_Scene<T> : Node2D
{
    public T Model;

    public virtual void Update() { }
}
