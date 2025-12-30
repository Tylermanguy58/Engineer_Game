using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public partial class DamageContext<TProperites, TState>
        where TProperites : HealthProperties
        where TState : HealthState
    {
        public TProperites properties;
        public TState state;
    }
}