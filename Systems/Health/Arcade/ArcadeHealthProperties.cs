using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    [GlobalClass]
    public partial class ArcadeHealthProperties : HealthProperties
    {
        [Export] public int maxOverheal;
    }
}