using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFreeLookState : State
{
    private PlayerStateMachine stateMachine;

    public PlayerFreeLookState(PlayerStateMachine stateMachine) {
        this.stateMachine = stateMachine;
    }
    
    public override void OnEnter()
    {
        Debug.Log("Entered");
    }

    public override void OnUpdate(float deltaTime)
    {
        Debug.Log("Updating");

        Vector3 motion = Vector3.zero;
        motion.x = stateMachine.InputReader.MovementValue.x;
        motion.z = stateMachine.InputReader.MovementValue.y;
        motion *= stateMachine.MoveSpeed;

        stateMachine.Controller.Move(motion * deltaTime);

    }

    public override void OnExit()
    {
        Debug.Log("Exited");
    }
}
