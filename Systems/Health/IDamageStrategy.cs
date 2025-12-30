using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public interface IDamageStrategy<TDamageContext, TProperties, TState> 
        where TState : HealthState 
        where TProperties : HealthProperties
        where TDamageContext : DamageContext<TProperties, TState> 
    {
        public void Damage(TDamageContext context);
    }
}