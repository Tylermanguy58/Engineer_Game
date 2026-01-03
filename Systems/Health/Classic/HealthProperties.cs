using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    [GlobalClass]
    public partial class HealthProperties : Resource
    {
        [Export] public int maxHealth;
    } 
}
