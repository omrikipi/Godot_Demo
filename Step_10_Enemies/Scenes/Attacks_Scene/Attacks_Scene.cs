using System.Collections.Generic;
using System.Linq;
using Godot;
using Interfaces;

public partial class Attacks_Scene : Base_Scene<IAttack_Model[]>
{
    public List<Entity> Enemies;

    private Button[] buttons;

    private IEntity_Model current => Enemies.FirstOrDefault()?.Model;

    public override void Update()
    {
        if (!current?.Is_Alive ?? false)
            Enemies.RemoveAt(0);
        for (int i = 0; i < buttons.Length; i++)
            buttons[i].Disabled = !Model[i].Can_Attack(current);
    }

    protected override void On_model_changed()
    {
        var vb = GetNode<VBoxContainer>("VBoxContainer");
        buttons = new Button[Model.Length];
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i] = Get_Button(i);
            vb.AddChild(buttons[i]);
        }
    }

    private Button Get_Button(int index)
    {
        var button = new Button();
        button.Text = Model[index].Name;
        button.Pressed += () => Model[index].Hit(current);
        return button;
    }
}
