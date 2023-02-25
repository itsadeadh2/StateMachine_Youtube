using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker : MonoBehaviour {
    public event Action OnGroundCollision;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Ground") {
            Debug.Log("Ground Collision!");
            OnGroundCollision?.Invoke();
        }
    }
}
