using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerCore core;
    public Rigidbody rb;

    [Header("Basic Movement")]
    public float maxSpeed = 10f;
    // public float acc = 1200f;
    
    public float riseSpeed = 10f;
    public float sinkSpeed = 10f;
    
    [Header("Aiming")]
    public float rotationSpeed = 15f;

    private void Awake() {
        core = GetComponent<PlayerCore>();
        rb = core.rigidbody;
    }

    public void MovePlayer(Vector2 moverDir) {
        core.rigidbody.velocity = new Vector3(moverDir.x, 0, moverDir.y) * maxSpeed;
    }

    public void Rise() {
        core.rigidbody.AddForce(10000f * Vector3.up);
    }

    public void Sink() {
        core.rigidbody.AddForce(-10000f * Vector3.up);
    }
    
    // private Vector2 V3ToV2(Vector3 v3) {
    //     return new Vector2(v3.x, v3.z);
    // }
    // private Vector3 V2ToV3(Vector2 v2, Vector3 modifyingVector) {
    //     return new Vector3(v2.x, modifyingVector.y, v2.y);
    // }

}

