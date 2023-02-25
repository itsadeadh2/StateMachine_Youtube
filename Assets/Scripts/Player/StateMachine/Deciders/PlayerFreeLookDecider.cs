using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFreeLookDecider : PlayerBaseDecider {

    public override event Action<PlayerStateMachine.PlayerStates> OnPlyerStateChangedEvent;

    public PlayerFreeLookDecider(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void OnEnter() {
        stateMachine.InputReader.JumpEvent += OnJumpPressedEvent;
    }

    public override void OnUpdate(float deltaTime) { }

    public override void OnExit() {
        stateMachine.InputReader.JumpEvent -= OnJumpPressedEvent;
    }

    private void OnJumpPressedEvent() {
        OnPlyerStateChangedEvent?.Invoke(PlayerStateMachine.PlayerStates.Jump);
    }
}
