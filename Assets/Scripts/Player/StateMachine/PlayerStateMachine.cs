using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine {

    [field: SerializeField] public InputReader InputReader { get; private set; }
    [field: SerializeField] public CharacterController Controller { get; private set; }

    [field: SerializeField] public float MoveSpeed { get; private set; }


    void Start() {
        SwitchState(new PlayerFreeLookState(this));
    }
}
