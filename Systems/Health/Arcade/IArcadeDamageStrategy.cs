using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public partial interface IArcadeDamageStrategy : IGenericDamageStrategy<ArcadeHealth, ArcadeDamageContext>
    {
    }
}