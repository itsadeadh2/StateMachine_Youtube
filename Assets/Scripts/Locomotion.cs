using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion
{
    private ForceReceiver forceReceiver;
    private CharacterController controller;

    public Locomotion(ForceReceiver forceReceiver, CharacterController controller) {
        this.forceReceiver = forceReceiver;
        this.controller = controller;
    }
    public void Move(Vector3 motion, float deltaTime) {
        motion += forceReceiver.Movement;
        controller.Move(motion * deltaTime);
    }
}
