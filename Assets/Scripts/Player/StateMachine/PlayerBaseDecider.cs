using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseDecider : State
{
    public virtual event Action<PlayerStateMachine.PlayerStates> OnPlyerStateChangedEvent;

    protected PlayerStateMachine stateMachine;

    public PlayerBaseDecider(PlayerStateMachine stateMachine) {
        this.stateMachine = stateMachine;
    }
}
