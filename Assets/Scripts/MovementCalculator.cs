using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCalculator
{
    public Vector3 Calculate(InputReader inputReader, float moveSpeed) {
        Vector3 motion = Vector3.zero;
        motion.x = inputReader.MovementValue.x;
        motion.z = inputReader.MovementValue.y;
        motion *= moveSpeed;
        return motion;
    }
}
