using Godot;
using System;

namespace ParadigmBlock.Systems.Firearm
{
    [GlobalClass]
    public partial class BaseFirearmData : Resource
    {
        [Export] public float Range;
        [Export] public int Damage;
        [Export] public float Spread;
        [Export] public float Recoil;
        [Export] public float ReloadSpeed;
        [Export] public float ShootCooldown;
        [Export] public float Capacity;
        [Export] public float Penetration;
    }
}