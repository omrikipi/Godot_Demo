using Interfaces;
using Messages;

namespace Models;

public class Timer_Model : ITimer_Model
{
    public int Time { get; }
    public double Current { get; set; }

    public Timer_Model(int time)
    {
        Time = time;
        Start();
    }

    public void Start()
    {
        Current = Time;
        new Start_Timer_Message(this);
    }
}