using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFreeLookState : State
{
    public override void OnEnter()
    {
        Debug.Log("Entered");
    }

    public override void OnUpdate(float deltaTime)
    {
        Debug.Log("Updating");
    }

    public override void OnExit()
    {
        Debug.Log("Exited");
    }
}
