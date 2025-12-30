using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public partial class ArcadeHealth : Health<
    ArcadeHealthProperties, 
    ArcadeHealthState, 
    ArcadeHealContext, 
    ArcadeDamageContext, 
    IArcadeHealStrategy, 
    IArcadeDamageStrategy>
    {

    }
}