using Controllers;
using Godot;

namespace Singletons;

public partial class Initializer : Node
{
    public Initializer()
    {
        new Timer_Controller();
        new Entity_Controller();
        new Heal_Controller();
        new Attack_Controller();
        new Dot_Attack_Controller();
    }
}