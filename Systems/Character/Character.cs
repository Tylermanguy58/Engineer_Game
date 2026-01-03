using Godot;
using System;
using ParadigmBlock.Systems.Health;

namespace ParadigmBlock.Systems.Character
{
    public partial class Character : Node3D
    {
        [Export] Node3D healthComponent;
        IHealthComponent health;

        public override void _Ready()
        {
            base._Ready();
            if(healthComponent is not IHealthComponent health)
                throw new InvalidOperationException($"Expected healthComponent implementing {nameof(IHealthComponent)}");
            this.health = health;
        }

        public void HandleInput()
        {

        }

        public override void _Process(double delta)
        {
            base._Process(delta);
            HandleInput();
        }
    }
}
