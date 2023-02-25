using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : PlayerBaseState {
    private MovementCalculator movementCalculator;
    private Locomotion locomotion;

    public PlayerJumpState(PlayerStateMachine stateMachine, PlayerJumpDecider decider, MovementCalculator movementCalculator, Locomotion locomotion) : base(stateMachine, decider) { 
        this.movementCalculator = movementCalculator;
        this.locomotion = locomotion;
    }

    public override void OnEnter() {
        base.OnEnter();
        this.stateMachine.ForceReceiver.Jump(10f);
    }

    public override void OnUpdate(float deltaTime) {
        Vector3 motion = movementCalculator.Calculate(stateMachine.InputReader, stateMachine.MoveSpeed);
        locomotion.Move(motion, deltaTime);

        base.OnUpdate(deltaTime);
    }

    public override void OnExit() {
        base.OnExit();
    }
}
