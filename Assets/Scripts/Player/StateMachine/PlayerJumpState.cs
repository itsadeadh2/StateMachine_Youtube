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
        this.stateMachine.ForceReceiver.Jump(10f);
    }

    public override void OnUpdate(float deltaTime) {
        Debug.Log("PlayerJumpState::OnUpdate");
        Vector3 motion = CalculateMovement();
        motion += stateMachine.ForceReceiver.Movement;

        stateMachine.Controller.Move(motion * deltaTime);

    }

    public override void OnExit() {
        Debug.Log("PlayerJumpState::OnExit");
    }

    private Vector3 CalculateMovement() {
        Vector3 motion = Vector3.zero;
        motion.x = stateMachine.InputReader.MovementValue.x;
        motion.z = stateMachine.InputReader.MovementValue.y;
        motion *= stateMachine.MoveSpeed;
        return motion;
    }
}
