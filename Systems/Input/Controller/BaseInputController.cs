using Godot;
using System;

namespace ParadigmBlock.Systems.Input
{
    public abstract partial class BaseInputController : Node
    {
        public abstract void HandleInput();
    }
}
