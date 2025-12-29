using Godot;
using System;
using System.ComponentModel;

namespace ParadigmBlock.Systems.Character
{
    public partial class CharacterController : Node
    {
        [Export]
        Node CharacterModel;

        public override void _Process(double delta)
        {
        }
    }
}

