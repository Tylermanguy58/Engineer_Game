using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public interface IArcadeHealStrategy : IHealStrategy<ArcadeHealContext, ArcadeHealthProperties, ArcadeHealthState>
    {

    }
}