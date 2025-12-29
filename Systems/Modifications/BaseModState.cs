using Godot;
using System;

namespace ParadigmBlock.Systems.Modifications
{
    [GlobalClass]
    public abstract partial class BaseModState : Resource
    {
        [Export] int quality;
        [Export] int level;
        [Export] int durability;
    }
}