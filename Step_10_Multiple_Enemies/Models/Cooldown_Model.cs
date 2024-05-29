using Commands;
using Messages;

namespace Models;

public class Cooldown_Model
{
    public int Cooldown { get; }
    public double Current { get; set; }
    public bool Is_On => Current > 0;

    public Cooldown_Model(int cooldown)
    {
        Cooldown = cooldown;
        Current = cooldown;
        new Model_Created_Message<Cooldown_Model>(this);
    }

    public void Reset()
    {
        Current = Cooldown;
        new Reset_Cooldown_Command(this);
    }
}