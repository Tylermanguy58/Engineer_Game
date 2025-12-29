using Godot;
using System;

namespace ParadigmBlock.Systems.Firearm
{
    public abstract partial class Firearm : Node3D
    {
        [Export] private BaseFirearmData defaultProperties;
        BaseFirearmState state;

        public override void _Ready()
        {
            state = new BaseFirearmState(defaultProperties);
        }

        public void PrimaryShoot()
        {

        }

        public void SecondaryShoot()
        {

        }

        public void PrimaryReload()
        {

        }

        public void SecondaryReload()
        {

        }
    }
}
