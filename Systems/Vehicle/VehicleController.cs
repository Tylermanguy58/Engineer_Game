using Godot;
using System;
using System.ComponentModel;

namespace ParadigmBlock.Systems.Vehicle
{
    public partial class VehicleController : Node
    {
        [Export]
        public VehicleInputController input;

        public override void _Process(double delta)
        {
        }
    }
}
