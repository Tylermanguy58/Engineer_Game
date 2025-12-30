using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public abstract partial class HealthComponent<
        TProperties, 
        TState, 
        THealContext, 
        TDamageContext, 
        THealStrategy, 
        TDamageStrategy> : Node3D, IHealthComponent 

        where TProperties : HealthProperties 
        where TState : HealthState
        where THealContext : HealContext<TProperties, TState>
        where TDamageContext : DamageContext<TProperties, TState>
        where THealStrategy : IHealStrategy<THealContext, TProperties, TState>
        where TDamageStrategy : IDamageStrategy<TDamageContext, TProperties, TState>
    {
        [Export] HealthProperties exportedProperties;
        protected TProperties properties;
        protected TState state;

        public override void _Ready()
        {
            base._Ready();

            if (exportedProperties == null)
            {
                throw new InvalidOperationException("exportedProperties is not assigned in the editor.");
            }

            if(exportedProperties is TProperties type)
            {
                properties = type;
            }
            else
            {
                throw new InvalidOperationException($"Expected {typeof(TProperties).Name} but got {exportedProperties.GetType().Name}");  
            }
        }

        public void Heal(HealContext<HealthProperties, HealthState> context, IHealStrategy<HealContext<HealthProperties, HealthState>, HealthProperties, HealthState> strategy)
        {
            if(context is THealContext contextType)
            {
                if(strategy is THealStrategy stratType)
                {
                    stratType.Heal(contextType);
                }
                else
                {
                    throw new InvalidOperationException($"Expected {typeof(THealStrategy).Name} but got {strategy.GetType().Name}");  
                }
            }
            else
            {
                throw new InvalidOperationException($"Expected {typeof(THealContext).Name} but got {context.GetType().Name}");  
            }
        }

        public void Damage()
        {
            throw new NotImplementedException();
        }
    }
}