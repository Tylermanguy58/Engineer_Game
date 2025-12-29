using Godot;
using System;

namespace ParadigmBlock.Systems.Modifications
{
    public abstract partial class Mod<TProperties, TState> where TProperties : BaseModProperties where TState : BaseModState
    {
        protected TProperties properties;
        protected TState state;

        public void SetState(TState state)
        {
            this.state = state;
        }

        public void SetProperties(TProperties properties)
        {
            this.properties = properties;
        }

        public TProperties GetProperites()
        {
            return properties;
        }

        public TState GetState()
        {
            return state;
        }
    }
}