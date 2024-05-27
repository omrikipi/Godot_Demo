using Godot;

namespace Resources;

[GlobalClass]
public partial class Attack_Resource : Named_Resource
{
	[Export]
	public int Cooldown;
	
	[Export]
	public int Damge;
}
