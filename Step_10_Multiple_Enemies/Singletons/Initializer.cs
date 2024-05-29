using Controllers;
using Godot;

namespace Singletons;

public partial class Initializer : Node
{
    public Initializer()
    {
        new Cooldown_Controller();
        new Entity_Controller();
        new Attack_Controller();
    }
}