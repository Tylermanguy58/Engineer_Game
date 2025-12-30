using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public interface IHealthComponent
    {
        public void Heal(HealContext<HealthProperties, HealthState> context, IHealStrategy<HealContext<HealthProperties, HealthState>, HealthProperties, HealthState> strategy);
        public void Damage();
    }
}