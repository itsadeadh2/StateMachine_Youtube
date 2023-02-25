using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour {
    protected State currentState;

    void Update() {
        currentState?.OnUpdate(Time.deltaTime);
    }

    protected void SwitchState(State newState) {
        currentState?.OnExit();
        currentState = newState;
        currentState?.OnEnter();
    }
}
