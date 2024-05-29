using Commands;

namespace Models;

public class Entity_Model
{
    public int Hp { get; set; }
    public Attack_Model Attack_Model { get; }
    public bool Is_Alive => Hp > 0;
    
    public Entity_Model(Entity_Resource resource)
    {
        Hp = resource.Hp;
        Attack_Model = new Attack_Model(this, resource);
    }

    public void Hit(int damage)
    {
        new Hit_Command(this, damage);
    }
}
