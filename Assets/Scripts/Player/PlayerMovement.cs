using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerCore core;

    [Header("Movement")]
    public float maxSpeed = 25f;
    public float povSpeedPercent = 0.5f;
    public float acceleration = 1200f;
    public float deceleration = 20f;
    
    public float rotationSpeed = 15f;
    
    // NOTE: Aiming is currently handled by Cinemachine
    [Header("Aiming")]
    public float xAimSensitivity = 80f;
    public float yAimSensitivity = 80f;
    public float minAimAngle = 90f;
    public float maxAimAngle = 90f;
    
    private float xAimRotation = 0f;

    [Header("Rise/ Sink")] 
    public float riseSpeed = 10f;
    public float sinkSpeed = 10f;
    
    [NonSerialized] public bool isRising = false;
    [NonSerialized] public bool isSinking = false;
    
    
    private void Awake() {
        core = GetComponent<PlayerCore>();
    }

    private void FixedUpdate() {
        if (!(isRising && isSinking)) {  // Cannot rise and sink at same time
            if (isRising) {
                Rise();
            }
            if (isSinking) {
                Sink();
            }
        }
        
    }

    public void MovePlayer(Vector2 moveDir) {
        if (!core.cam.aiming) {
            MoveInFreecam(moveDir);
        }
        else {
            MoveInPov(moveDir);
        }
    }

    // TODO: Implement acceleration
    private void MoveInFreecam(Vector2 moveDir) {
        if (moveDir.magnitude > 0.1) {
            float targetAngle = Mathf.Atan2(moveDir.x, moveDir.y) * Mathf.Rad2Deg + core.camTransform.eulerAngles.y;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, targetAngle, 0), rotationSpeed * Time.deltaTime);
        
            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            core.rb.velocity = moveDirection * maxSpeed;
        }
        else {  // Stop moving -> decelerate to zero in currentDir
            core.rb.velocity = Vector3.Lerp(core.rb.velocity,  Vector3.zero, deceleration * Time.deltaTime);
        }
    }

    private void MoveInPov(Vector2 moveDir) {
        if (moveDir.magnitude > 0.1) {
            Vector3 forwardMove = moveDir.y * transform.forward;
            Vector3 lateralMove = moveDir.x * transform.right;
            core.rb.velocity = (forwardMove + lateralMove) * maxSpeed * povSpeedPercent;
        }
        else {  // Stop moving -> decelerate to zero in currentDir
            core.rb.velocity = Vector3.Lerp(core.rb.velocity,  Vector3.zero, deceleration * Time.deltaTime);
        }
    }

    public void AimPlayer(Vector2 aimDir) {
        if (!core.cam.aiming) return;
        
        // Left/right aim
        float dyAimRotation = aimDir.x * yAimSensitivity * Time.deltaTime;
        
        // Up/down aim
        xAimRotation -= aimDir.y * xAimSensitivity * Time.deltaTime;
        xAimRotation = Mathf.Clamp(xAimRotation, -maxAimAngle, minAimAngle);
        
        Vector3 prevAngles = transform.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(xAimRotation, prevAngles.y + dyAimRotation, prevAngles.z);
    }
    
    public void ResetAimAngle() {
        xAimRotation = 0f;
    }

    public void Rise() {
        core.rb.velocity += riseSpeed * Vector3.up * Time.deltaTime;
    }

    public void Sink() {
        core.rb.velocity += sinkSpeed * Vector3.down * Time.deltaTime;
    }
    
    private Vector2 V3ToV2(Vector3 v3) {
        return new Vector2(v3.x, v3.z);
    }
    private Vector3 V2ToV3(Vector2 v2, float y) {
        return new Vector3(v2.x, y, v2.y);
    }

}

