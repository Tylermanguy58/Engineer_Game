using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public interface IGenericHealStrategy<
        THealthComponent,
        THealContext
        > 

        where THealthComponent : IHealthComponent
        where THealContext : GenericHealContext 
    {
        public void Heal(THealthComponent health, THealContext context);        
    }
}