using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseState : State {
    protected PlayerStateMachine stateMachine;

    public PlayerBaseState(PlayerStateMachine stateMachine) {
        this.stateMachine = stateMachine;
    }

    protected Vector3 CalculateMovement() {
        Vector3 motion = Vector3.zero;
        motion.x = stateMachine.InputReader.MovementValue.x;
        motion.z = stateMachine.InputReader.MovementValue.y;
        motion *= stateMachine.MoveSpeed;
        return motion;
    }

    protected void Move(Vector3 motion, float deltaTime) {
        motion += stateMachine.ForceReceiver.Movement;
        stateMachine.Controller.Move(motion * deltaTime);
    }
}
