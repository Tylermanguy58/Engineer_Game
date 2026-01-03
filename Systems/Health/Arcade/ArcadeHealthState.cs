using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public partial class ArcadeHealthState : HealthState
    {
        public int overHeal;

        public ArcadeHealthState(ArcadeHealthProperties defaultProperties) : base(defaultProperties)
        {
            overHeal = defaultProperties.maxOverheal;
        }
    }
}