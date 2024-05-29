using System.Linq;
using Godot;
using Interfaces;
using Models;
using Resources;

public partial class Entity : Base_Scene<IEntity_Model>
{
    [Export]
    public Entity_Resource Resource;

    [Export]
    public Entity[] Enemies;

    private Label hp_lable;

    private Button[] attack_buttons;

    public override void _Ready()
    {
        Model = new Entity_Model(Resource);
        hp_lable = GetNode<Label>("Hp_Label");
        GetNode<Label>("Name_Label").Text = Resource.Name;
        var attacks_scene = GetNode<Attacks_Scene>("Attacks");
        attacks_scene.Enemies = Enemies.ToList();
        attacks_scene.Model = Model.Attacks;
    }

    public override void Update()
    {
        hp_lable.Text = Model.Is_Alive ? Model.Hp.Value.ToString("D3") : "Dead";
    }
}
