using Godot;
using System;
using ParadigmBlock.Systems.Character;
using ParadigmBlock.Systems.Vehicle;
using System.Collections.Generic;

namespace ParadigmBlock.Systems.Player
{
    public enum PlayerControllers
    {
        VEHICLE_CONTROLLER,
        CHARACTER_CONTROLLER
    }

    public partial class PlayerController : Node
    {
        Dictionary<PlayerControllers, Node> playerControllers = new Dictionary<PlayerControllers, Node>();

        [Export]
        PlayerControllers currentController;
        [Export]
        Node vehicleController;
        [Export]
        Node characterController;

        public override void _Ready()
        {
            playerControllers.Add(PlayerControllers.VEHICLE_CONTROLLER, vehicleController);
            playerControllers.Add(PlayerControllers.CHARACTER_CONTROLLER, characterController);
            foreach (PlayerControllers key in playerControllers.Keys)
            {
                playerControllers[key].ProcessMode = ProcessModeEnum.Disabled;
            }
            SelectCurrentController(currentController);
        }

        public override void _Process(double delta)
        {
        }

        public void SelectCurrentController(PlayerControllers controller)
        {
            playerControllers[currentController].ProcessMode = ProcessModeEnum.Disabled;
            currentController = controller;
            playerControllers[controller].ProcessMode = ProcessModeEnum.Inherit;
        }
    }
}
