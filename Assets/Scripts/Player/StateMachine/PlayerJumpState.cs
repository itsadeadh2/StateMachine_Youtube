using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : State {
    private PlayerStateMachine stateMachine;

    public PlayerJumpState(PlayerStateMachine stateMachine) {
        this.stateMachine = stateMachine;
    }

    public override void OnEnter() {
        Debug.Log("PlayerJumpState::OnEnter");
    }

    public override void OnUpdate(float deltaTime) {
        Debug.Log("PlayerJumpState::OnUpdate");

    }

    public override void OnExit() {
        Debug.Log("PlayerJumpState::OnExit");
    }
}
