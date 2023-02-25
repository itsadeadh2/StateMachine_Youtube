using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State {
    public abstract void OnEnter();
    public abstract void OnUpdate(float deltaTime);
    public abstract void OnExit();
}
