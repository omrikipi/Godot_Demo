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
    private Button attack_button;


    public override void _Ready()
    {
        GetNode<Label>("Name_Label").Text = Resource.Name;
        hp_lable = GetNode<Label>("Hp_Label");
        attack_button = GetNode<Button>("Attack_Button");
        attack_button.Text = Resource.Attack.Name;
        Model = new Entity_Model(Resource);
    }

    public override void Update()
    {
        hp_lable.Text = Model.Hp.ToString("D3");
        attack_button.Disabled = !Model.Attack_Model.Can_Attack(Enemy.Model);
    }

    public void On_button_pressed()
    {
        Model.Attack_Model.Attack(Enemy.Model);
    }
}
