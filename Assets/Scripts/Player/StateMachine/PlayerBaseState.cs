using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseState : State {
    protected PlayerStateMachine stateMachine;
    protected PlayerBaseDecider decider;


    public PlayerBaseState(PlayerStateMachine stateMachine, PlayerBaseDecider decider) {
        this.stateMachine = stateMachine;
        this.decider = decider;
    }
    public override void OnEnter() {
        decider.OnEnter();
        decider.OnPlyerStateChangedEvent += OnPlayerStateChanged;
    }

    public override void OnUpdate(float deltaTime) {
        decider.OnUpdate(deltaTime);
    }

    public override void OnExit() {
        decider.OnExit();
        decider.OnPlyerStateChangedEvent -= OnPlayerStateChanged;
    }

    private void OnPlayerStateChanged(PlayerStateMachine.PlayerStates newState) {
        this.stateMachine.SelectState(newState);
        return;
    }
}
