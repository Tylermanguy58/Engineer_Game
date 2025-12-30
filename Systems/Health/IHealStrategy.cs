using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public interface IHealStrategy<THealContext, TProperties, TState> 
        where TProperties : HealthProperties 
        where TState : HealthState
        where THealContext : HealContext<TProperties, TState> 
    {
        public void Heal(THealContext context);        
    }
}