using Events;
using Godot;
using Models;
using System;

public partial class Main : Node2D
{
    public override void _Ready()
    {
        var entity_1 = GetNode<Entity>("Entity_1");
        entity_1.Model = new Entity_Model(5);
        var entity_2 = GetNode<Entity>("Entity_2");
        entity_2.Model = new Entity_Model(7);

        Game_Update.Invoke();

        base._Ready();
    }
}
