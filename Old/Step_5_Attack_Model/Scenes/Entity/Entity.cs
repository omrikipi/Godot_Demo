using Godot;
using Models;
using Resources;

public partial class Entity : Base_Scene<Entity_Model>
{
    [Export]
    public Entity_Resource Resource;

    [Export]
    public Entity Enemy;

    private Label hp_lable;

    public override void _Ready()
    {
        Model = new Entity_Model(Resource);
        hp_lable = GetNode<Label>("Hp_Label");
        GetNode<Label>("Name_Label").Text = Resource.Name;
        GetNode<Button>("Attack_Button").Text = Resource.Attack.Name;
    }

    public override void Update()
    {
        hp_lable.Text = Model.Is_Alive ? Model.Hp.ToString("D3") : "Dead";
    }

    public void On_button_pressed()
    {
        Model.Hit(Enemy.Model);
    }
}
