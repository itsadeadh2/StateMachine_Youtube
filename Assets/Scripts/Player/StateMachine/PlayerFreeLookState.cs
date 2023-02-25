using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFreeLookState : State {
    private PlayerStateMachine stateMachine;

    public PlayerFreeLookState(PlayerStateMachine stateMachine) {
        this.stateMachine = stateMachine;
    }

    public override void OnEnter() {
        Debug.Log("Entered");
        stateMachine.InputReader.JumpEvent += OnJumpPressed;
    }

    public override void OnUpdate(float deltaTime) {
        Debug.Log("Updating");

        Vector3 motion = CalculateMovement();

        stateMachine.Controller.Move(motion * deltaTime);
    }

    public override void OnExit() {
        Debug.Log("Exited");
    }

    private Vector3 CalculateMovement() {
        Vector3 motion = Vector3.zero;
        motion.x = stateMachine.InputReader.MovementValue.x;
        motion.z = stateMachine.InputReader.MovementValue.y;
        motion *= stateMachine.MoveSpeed;
        return motion;
    }

    private void OnJumpPressed() {
        stateMachine.SelectState(PlayerStateMachine.PlayerStates.Jump);
    }
}
