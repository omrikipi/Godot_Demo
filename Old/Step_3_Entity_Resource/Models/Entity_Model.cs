using Godot;
using System;

namespace Models;

public class Entity_Model
{
    public int Hp { get; set; }

    public Entity_Model(int hp)
    {
        Hp = hp;
    }
}
