using Events;
using Godot;
using Models;

public partial class Entity : Base_Scene<Entity_Model>
{
    [Export]
    public Entity_Resource Resource;

    [Export]
    public Entity Enemy;

    private Label hp_lable;

    public override void _Ready()
    {
        Model = new Entity_Model(Resource.Hp);
        hp_lable = GetNode<Label>("Hp_Label");
    }

    public override void Update()
    {
        hp_lable.Text = Model.Hp.ToString("D3");
    }

    public void On_button_pressed()
    {
        Enemy.Model.Hp -= Resource.Damge;
        Game_Update.Invoke();
    }
}