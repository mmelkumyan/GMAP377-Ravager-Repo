using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerCore core;
    private Rigidbody rb;

    [Header("Basic Movement")]
    public float maxSpeed = 10f;
    public float acceleration = 1200f;
    public float deceleration = 20f;
    
    public float riseSpeed = 10f;
    public float sinkSpeed = 10f;
    
    public float rotationSpeed = 15f;
    
    // NOTE: Aiming is currently handled by Cinemachine
    // [Header("Aiming")]
    // float rotationPower = 1f;
    
    private void Awake() {
        core = GetComponent<PlayerCore>();
        rb = core.rb;
    }

    public void MovePlayer(Vector2 moveDir) {
        // TODO: Acceleration and deceleration
        if (moveDir.magnitude > 0.1) {
            float targetAngle = Mathf.Atan2(moveDir.x, moveDir.y) * Mathf.Rad2Deg + core.cam.eulerAngles.y;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, targetAngle, 0), rotationSpeed * Time.deltaTime);
            
            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            rb.velocity = moveDirection * maxSpeed;
        }
        else { //off left stick -> decellerate to zero in currentDir
            rb.velocity = Vector3.Lerp(rb.velocity,  Vector3.zero, deceleration * Time.deltaTime);
        }
    }

    public void AimPlayer(Vector2 aimDir) {
        // NOTE: Right now aiming is handled by Cinecachine
        
        // aimDir = aimDir.normalized;
        // followTransform.transform.rotation *= Quaternion.AngleAxis(_look.x * rotationPower, Vector3.up);
        // if (aimDir.magnitude > 0.1) {
        //     Quaternion test = Quaternion.AngleAxis(aimDir.x * rotationPower, Vector3.up);
        //     core.cameraFollowTarget.transform.rotation *= Quaternion.AngleAxis(aimDir.x * rotationPower, Vector3.up);
        // }
    }

    public void Rise() {
        core.rb.AddForce(10000f * Vector3.up);
    }

    public void Sink() {
        core.rb.AddForce(-10000f * Vector3.up);
    }
    
    private Vector2 V3ToV2(Vector3 v3) {
        return new Vector2(v3.x, v3.z);
    }
    private Vector3 V2ToV3(Vector2 v2, float y) {
        return new Vector3(v2.x, y, v2.y);
    }

}

