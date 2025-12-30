using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public partial class ArcadeHealth : HealthComponent<
    ArcadeHealthProperties, 
    ArcadeHealthState, 
    ArcadeHealContext, 
    ArcadeDamageContext, 
    IArcadeHealStrategy, 
    IArcadeDamageStrategy>
    {

    }
}