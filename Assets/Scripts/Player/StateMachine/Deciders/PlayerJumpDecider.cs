using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpDecider : PlayerBaseDecider {
    public PlayerJumpDecider(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override event Action<PlayerStateMachine.PlayerStates> OnPlyerStateChangedEvent;

    public override void OnEnter() {
    }

    public override void OnUpdate(float deltaTime) {
        if (stateMachine.Controller.isGrounded) {
            OnPlyerStateChangedEvent?.Invoke(PlayerStateMachine.PlayerStates.FreeLook);
        }
    }

    public override void OnExit() {
    }
}
