using Godot;
using System;

namespace ParadigmBlock.Systems.Movement
{
    public abstract partial class BaseMovementController : Node
    {
        public abstract void Move();
    }
}
