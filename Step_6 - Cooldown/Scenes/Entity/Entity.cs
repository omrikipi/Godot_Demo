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
        Model = new Entity_Model(Resource);
        hp_lable = GetNode<Label>("Hp_Label");
        GetNode<Label>("Name_Label").Text = Resource.Name;
        attack_button = GetNode<Button>("Attack_Button");
        attack_button.Text = Resource.Attack.Name;
    }

    public override void Update()
    {
        hp_lable.Text = Model.Is_Alive ? Model.Hp.ToString("D3") : "Dead";
        attack_button.Disabled = !Model.Attack_Model.Can_Attack(Enemy.Model);
    }

    public void On_button_pressed()
    {
        Model.Attack_Model.Hit(Enemy.Model);
    }
}
