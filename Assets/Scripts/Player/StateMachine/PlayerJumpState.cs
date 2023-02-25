using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : PlayerBaseState {

    public PlayerJumpState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void OnEnter() {
        this.stateMachine.ForceReceiver.Jump(10f);
    }

    public override void OnUpdate(float deltaTime) {
        Vector3 motion = CalculateMovement();
        Move(motion, deltaTime);
        if (stateMachine.Controller.isGrounded) {
            stateMachine.SelectState(PlayerStateMachine.PlayerStates.FreeLook);
        }
    }

    public override void OnExit() {
    }
}
