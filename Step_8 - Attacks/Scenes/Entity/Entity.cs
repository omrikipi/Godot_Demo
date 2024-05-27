using Godot;
using Interfaces;
using Models;
using Resources;

public partial class Entity : Base_Scene<IEntity_Model>
{
    [Export]
    public Entity_Resource Resource;

    [Export]
    public Entity Enemy;

    private Label hp_lable;

    private Button[] attack_buttons;

    public override void _Ready()
    {
        Model = new Entity_Model(Resource);
        hp_lable = GetNode<Label>("Hp_Label");
        GetNode<Label>("Name_Label").Text = Resource.Name;
        Setup_Buttons();
    }

    private void Setup_Buttons()
    {
        attack_buttons = new Button[3];
        for (int i = 0; i < attack_buttons.Length; i++)
        {
            attack_buttons[i] = GetNode<Button>("Attack_Button_" + (i + 1));
            if (i < Resource.Attacks.Length)
                Setup_Button(i);
            else
                attack_buttons[i].Visible = false;
        }
    }


    private void Setup_Button(int i)
    {
        attack_buttons[i].Text = Resource.Attacks[i].Name;
        attack_buttons[i].Pressed += () =>
            Model.Attack_Models[i].Hit(Enemy.Model);
    }

    public override void Update()
    {
        hp_lable.Text = Model.Is_Alive ? Model.Hp.ToString("D3") : "Dead";
        for (int i = 0; i < Model.Attack_Models.Length; i++)
            attack_buttons[i].Disabled = !Model.Attack_Models[i].Can_Attack(Enemy.Model);
    }
}
