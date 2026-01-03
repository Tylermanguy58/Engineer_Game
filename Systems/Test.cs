using Godot;
using System;
using ParadigmBlock.Systems.Health;
using System.Diagnostics.CodeAnalysis;

public partial class Test : Node
{
    [Export] Node node;
    private IHealthComponent component;
    public override void _Ready()
    {
        base._Ready();
        if(node is IHealthComponent component)
        {
            this.component = component;
            ArcadeHealContext context = new ArcadeHealContext();
        }
    }
    public override void _Process(double delta)
    {
        base._Process(delta);
    }
}
