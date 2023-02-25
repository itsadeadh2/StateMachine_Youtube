using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFreeLookState : PlayerBaseState {
    public PlayerFreeLookState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void OnEnter() {
        stateMachine.InputReader.JumpEvent += OnJumpPressed;
    }

    public override void OnUpdate(float deltaTime) {

        Vector3 motion = CalculateMovement();

        Move(motion, deltaTime);
    }

    public override void OnExit() {
        stateMachine.InputReader.JumpEvent -= OnJumpPressed;
    }

    private void OnJumpPressed() {
        stateMachine.SelectState(PlayerStateMachine.PlayerStates.Jump);
    }
}
