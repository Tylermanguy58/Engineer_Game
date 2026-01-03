using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public abstract partial class HealthComponent<
        TSelf,            //concrete class
        TProperties,  //property
        TState,     //state
        THealContext,   //context for heal strategy
        TDamageContext,  //context for damage strategy
        THealStrategy,    //heal strategy
        TDamageStrategy  //damage strategy
        > 
        : Node3D, IHealthComponent 

        where TSelf : HealthComponent<TSelf, TProperties, TState, THealContext, TDamageContext, THealStrategy, TDamageStrategy>
        where TProperties : HealthProperties 
        where TState : HealthState
        where THealContext : GenericHealContext
        where TDamageContext : GenericDamageContext
        where THealStrategy : IGenericHealStrategy<TSelf, THealContext>
        where TDamageStrategy : IGenericDamageStrategy<TSelf, TDamageContext>
    {
        //exported abstract properties
        [Export] private HealthProperties exportedProperties;
        //type specific properties
        protected TProperties properties;
        //type specific state
        protected TState state;

        public event Action<IHealthComponent, GenericHealContext, IGenericHealStrategy<IHealthComponent, GenericHealContext>> OnHeal;
        public event Action<IHealthComponent, GenericDamageContext, IGenericDamageStrategy<IHealthComponent, GenericDamageContext>> OnDamage;

        public override void _Ready()
        {
            base._Ready();

            if (exportedProperties == null)
            {
                throw new InvalidOperationException("exportedProperties is not assigned in the editor.");
            }

            //cast the abstract exported properties to the typed properties
            if(exportedProperties is TProperties type)
            {
                properties = type;
            }
            else
            {
                throw new InvalidOperationException($"Expected {typeof(TProperties).Name} but got {exportedProperties.GetType().Name}");  
            }
        }

        private bool CanApplyStrategy(object strategy)
        {
            if(strategy is THealStrategy) return true;
            return false;
        }


        //GOAL: MAKE INTENT BASED, THIS METHOD IS BREAKING ENCAPSULATION, BY TELLING HOW TO DO, SHOULD BE TELLING WHAT TO DO, AND SHOULD BE INTERPERETED
        public void Heal(GenericHealContext context, IGenericHealStrategy<IHealthComponent, GenericHealContext> strategy)
        {
            //cast abstract context to the more specific abstraction of context in this health object
            if (context is not THealContext contextType)
                throw new InvalidOperationException($"Expected {typeof(THealContext).Name} but got {context.GetType().Name}");

            //cast abstract strategy to the more specific abstraction of strategy in this health object
            if (strategy is not THealStrategy stratType)
                throw new InvalidOperationException($"Expected {typeof(THealStrategy).Name} but got {strategy.GetType().Name}");

            if(CanApplyStrategy(strategy))
            {
                //casted strategy heal method, delegates to specific implementation
                stratType.Heal((TSelf)this, contextType);
                //invoke on heal
                OnHeal?.Invoke(this, context, strategy);
            }
        }

        public void Damage(GenericDamageContext context, IGenericDamageStrategy<IHealthComponent, GenericDamageContext> strategy)
        {
            //cast abstract context to the more specific abstraction of context in this health object
            if (context is not TDamageContext contextType)
                throw new InvalidOperationException($"Expected {typeof(TDamageContext).Name} but got {context.GetType().Name}");

            //cast abstract strategy to the more specific abstraction of strategy in this health object
            if (strategy is not TDamageStrategy stratType)
                throw new InvalidOperationException($"Expected {typeof(TDamageStrategy).Name} but got {strategy.GetType().Name}");
            
            //casted strategy damage method, delegates to specific implementation
            stratType.Damage((TSelf)this, contextType);
            
            //invoke on damage
            OnDamage?.Invoke(this, context, strategy);
        }
    }
}