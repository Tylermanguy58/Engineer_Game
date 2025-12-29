using Godot;
using System;

namespace ParadigmBlock.Systems.Firearm
{
    public partial class BaseFirearmState
    {
        BaseFirearmData defaultValues;
        BaseFirearmData state;  
        public BaseFirearmState(BaseFirearmData defaultValues)
        {
            this.defaultValues = defaultValues;
            state = defaultValues;
        }
        public BaseFirearmState(BaseFirearmData defaultValues, BaseFirearmData state)
        {
            this.defaultValues = defaultValues;
            this.state = state;
        }

        public void SetState(BaseFirearmData state)
        {
            this.state = state;
        }
    }
}