using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public interface IArcadeHealStrategy : IGenericHealStrategy<ArcadeHealth, ArcadeHealContext>
    {
    }
}