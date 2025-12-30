using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public partial class HealContext<TProperties, TState>
        where TProperties : HealthProperties
        where TState : HealthState
    {
        public TProperties properties;
        public TState state;
        public Health health;
    }
}