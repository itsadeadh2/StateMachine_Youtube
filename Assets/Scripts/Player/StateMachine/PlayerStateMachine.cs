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

    [field: SerializeField] public float MoveSpeed { get; private set; }


    void Start() {
        states = new Dictionary<PlayerStates, State>();

        states.Add(PlayerStates.FreeLook, new PlayerFreeLookState(this));
        states.Add(PlayerStates.Jump, new PlayerJumpState(this));

        SelectState(PlayerStates.FreeLook);
    }


    public void SelectState(PlayerStates newState) {
        var state = states[newState];
        if (state == null) return;
        SwitchState(state);
    }
}
