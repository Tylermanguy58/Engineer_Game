using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public abstract partial class Health<TProperties, TState, THealContext, TDamageContext, THealStrategy, TDamageStrategy> : Node3D 
        where TProperties : HealthProperties 
        where TState : HealthState
        where THealContext : HealContext<TProperties, TState>
        where TDamageContext : DamageContext<TProperties, TState>
        where THealStrategy : IHealStrategy<THealContext>
        where TDamageStrategy : IDamageStrategy<TDamageContext>
    {
        [Export] HealthProperties properties;
        protected TProperties properties;
        protected TState state;

        public Health()
        {
            if(properties is TProperties type)
            {
                properties = type;
            }
            else
            {
                throw new InvalidOperationException($"Expected {typeof(TProperties).Name} but got {propertiesAsset.GetType().Name}");  
            }
            state = new TState();
        }

        public void Heal(THealContext context, THealStrategy strategy)
        {
            strategy.Heal(context);
        }
        public void Damage(TDamageContext context, TDamageStrategy strategy)
        {
            strategy.Damage(context);
        }
    }
}