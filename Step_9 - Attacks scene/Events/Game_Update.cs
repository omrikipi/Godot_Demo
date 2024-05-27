using Core;

namespace Events;

public class Game_Update_Event : Event<Game_Update_Event>
{
}

public class Game_Time_Event : Event<Game_Time_Event, double>
{
}