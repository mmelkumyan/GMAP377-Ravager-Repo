using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private PlayerCore core;
    private PlayerControls playerControls;
    
    private Vector2 moveInputDirection;
    private Vector2 aimInputDirection;

    private void Awake() {
        core = GetComponent<PlayerCore>();
        playerControls = new PlayerControls();
    }

    private void Start() {
        // TODO: Hide mouse when playing
        // if (playerControls.Gameplay.Aim.bindings<>...)
        // Cursor.lockState = CursorLockMode.Locked;  
        
        playerControls.Gameplay.Rise.performed += ctx => core.movement.isRising = true;
        playerControls.Gameplay.Rise.canceled += ctx => core.movement.isRising = false;
        
        playerControls.Gameplay.Sink.performed += ctx => core.movement.isSinking = true;
        playerControls.Gameplay.Sink.canceled += ctx => core.movement.isSinking = false;
        
        playerControls.Gameplay.PunchLeft.performed += ctx => core.arms.PunchLeft();
        playerControls.Gameplay.PunchRight.performed += ctx => core.arms.PunchRight();
        
        playerControls.Gameplay.Aim.performed += ctx => core.cam.aiming = true;
        playerControls.Gameplay.Aim.canceled += ctx => core.cam.aiming = false;
        playerControls.Gameplay.Aim.canceled += ctx => core.movement.ResetAimAngle();
        playerControls.Gameplay.Aim.canceled += ctx => core.cam.ResetFreelookPos();
        
    }

    private void FixedUpdate() {
        aimInputDirection = playerControls.Gameplay.Look.ReadValue<Vector2>();
        core.movement.AimPlayer(aimInputDirection);
        moveInputDirection = playerControls.Gameplay.Move.ReadValue<Vector2>();
        core.movement.MovePlayer(moveInputDirection);
    }

    private void OnEnable() {
        playerControls.Gameplay.Enable();
    }

    private void OnDisable() {
        playerControls.Gameplay.Disable();
    }
}
