using Controllers;
using Godot;

namespace Singletons;

public partial class Initializer : Node
{
    public Initializer()
    {
        new Creat_Models_Controller();
        new Timer_Controller();
        new Heal_Controller();
        new Attack_Controller();
        new Over_Time_Controller();
        new Damage_Controller();
    }
}