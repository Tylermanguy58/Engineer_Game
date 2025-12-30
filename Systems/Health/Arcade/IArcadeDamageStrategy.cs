using Godot;
using System;

namespace ParadigmBlock.Systems.Health
{
    public partial class IArcadeDamageStrategy : IDamageStrategy<ArcadeDamageContext, ArcadeHealthProperties, ArcadeHealthState>
    {
        public void Damage(ArcadeDamageContext context)
        {
            throw new NotImplementedException();
        }
    }
}