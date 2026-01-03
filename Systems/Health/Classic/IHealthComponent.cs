using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public interface IHealthComponent
    {
        public event Action<IHealthComponent, GenericHealContext, IGenericHealStrategy<IHealthComponent, GenericHealContext>> OnHeal;
        public event Action<IHealthComponent, GenericDamageContext, IGenericDamageStrategy<IHealthComponent, GenericDamageContext>> OnDamage;
        public void Heal(GenericHealContext context, IGenericHealStrategy<IHealthComponent, GenericHealContext> strategy);
        public void Damage(GenericDamageContext context, IGenericDamageStrategy<IHealthComponent, GenericDamageContext> strategy);
    }
}