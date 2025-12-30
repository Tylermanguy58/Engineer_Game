using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public interface IHealStrategy<THealContext> where THealContext : HealContext
    {
        public void Heal(THealContext context);        
    }
}