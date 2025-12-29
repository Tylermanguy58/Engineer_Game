using Godot;
using System;

namespace ParadigmBlock.Systems.Firearm
{
    public interface IFirearmStrategy
    {
        void PrimaryShoot();
        void SecondaryShoot();
        void PrimaryReload();
        void SecondaryReload();
    }
}