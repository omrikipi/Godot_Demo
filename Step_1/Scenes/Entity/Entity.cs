using Godot;

public partial class Entity : Base_Scene<Entity_Model>
{
    private Label hp_lable;

    public override void _Ready()
    {
        hp_lable = GetNode<Label>("Hp_Label");
    }

    public override void Update()
    {
        hp_lable.Text = Model.Hp.ToString("D3");
    }
}
