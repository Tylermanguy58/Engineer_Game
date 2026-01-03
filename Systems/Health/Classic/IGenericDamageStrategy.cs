using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public interface IGenericDamageStrategy<
        THealthComponent,
        TDamageContext
        >

        where THealthComponent : IHealthComponent
        where TDamageContext : GenericDamageContext
    {
        public void Damage(THealthComponent health, TDamageContext context);
    }
}