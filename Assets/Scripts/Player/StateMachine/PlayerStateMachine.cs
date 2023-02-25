using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine {

    public enum PlayerStates {
        FreeLook,
        Jump
    }
    private Dictionary<PlayerStates, State> states;

    [field: SerializeField] public InputReader InputReader { get; private set; }
    [field: SerializeField] public CharacterController Controller { get; private set; }
    [field: SerializeField] public ForceReceiver ForceReceiver { get; private set; }

    [field: SerializeField] public float MoveSpeed { get; private set; }


    void Start() {
        states = new Dictionary<PlayerStates, State>();
        MovementCalculator movementCalculator = new MovementCalculator();
        Locomotion locomotion = new Locomotion(ForceReceiver, Controller);

        var playerFreeLookDecider = new PlayerFreeLookDecider(this);
        var playerJumpDecider = new PlayerJumpDecider(this);

        var playerFreeLookState = new PlayerFreeLookState(this, playerFreeLookDecider, movementCalculator, locomotion);
        var playerJumpState = new PlayerJumpState(this, playerJumpDecider, movementCalculator, locomotion);

        states.Add(PlayerStates.FreeLook, playerFreeLookState);
        states.Add(PlayerStates.Jump, playerJumpState);

        SelectState(PlayerStates.FreeLook);
    }


    public void SelectState(PlayerStates newState) {
        var state = states[newState];
        if (state == null) return;
        SwitchState(state);
    }

    private void OnGUI() {
        GUILayout.Label($"<color='yellow'><size=24>Current State:\n<color='yellow'>{currentState}</color></size></color>");
    }
}
