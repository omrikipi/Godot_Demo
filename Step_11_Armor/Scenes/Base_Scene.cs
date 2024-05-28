using Events;
using Godot;

public partial class Base_Scene<TModel> : Node2D
{
    private TModel model;
    public TModel Model
    {
        get => model;
        set
        {
            model = value;
            On_model_changed();
        }
    }

    public Base_Scene()
    {
        Game_Update_Event.Listen(Update);
    }

    public virtual void Update() { }
    protected virtual void On_model_changed() { }
}
