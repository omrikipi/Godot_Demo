using Godot;

public partial class Base_Scene<T> : Node2D
{
    public T Model;

    public virtual void Update() { }
    public virtual void Update(float delta) { }
}
