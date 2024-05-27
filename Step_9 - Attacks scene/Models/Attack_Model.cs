using Events;
using Interfaces;
using Resources;

namespace Models;

public class Attack_Model : IAttack_Model
{
    private readonly int damge;
    private readonly int cooldown;
    private readonly IEntity_Model owner;
    private double current_cooldown;
    private bool in_cool_down => current_cooldown > 0;

    public string Name { get; }


    public Attack_Model(IEntity_Model owner, Attack_Resource resource)
    {
        damge = resource.Damge;
        cooldown = resource.Cooldown;
        Name = resource.Name;
        this.owner = owner;
        Reset_cooldown();
    }

    public void Hit(IEntity_Model enemy)
    {
        if (Can_Attack(enemy))
        {
            Reset_cooldown();
            enemy.Hp -= damge;
        }
    }


    public bool Can_Attack(IEntity_Model enemy)
    {
        return !in_cool_down & owner.Is_Alive & enemy.Is_Alive;
    }


    private void On_game_time_event(double time)
    {
        current_cooldown -= time;
        if (!in_cool_down)
        {
            Game_Time_Event.Unlisten(On_game_time_event);
            Game_Update_Event.Invoke();
        }
    }

    private void Reset_cooldown()
    {
        current_cooldown = cooldown;
        Game_Time_Event.Listen(On_game_time_event);
    }
}
