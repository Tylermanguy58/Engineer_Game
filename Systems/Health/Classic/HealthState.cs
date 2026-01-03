using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public partial class HealthState
    {
        public int health;
        public bool isHealable;
        public bool isDamageable;

        public HealthState(HealthProperties defaultProperties)
        {
            health = defaultProperties.maxHealth;
            isHealable = true;
            isDamageable = true;
        }
    }
}