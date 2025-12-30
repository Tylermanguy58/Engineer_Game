using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public interface IDamageStrategy<TDamageContext> where TDamageContext : DamageContext
    {
        public void Damage(TDamageContext context);
    }
}