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
        playerControls.Gameplay.Rise.performed += ctx => core.movement.Rise();
        playerControls.Gameplay.Sink.performed += ctx => core.movement.Sink();
    }

    private void Update() {
        // Debug.Log(aimInputDirection);
        aimInputDirection = playerControls.Gameplay.Look.ReadValue<Vector2>();
        core.movement.AimPlayer(aimInputDirection);
    }

    private void FixedUpdate() {
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
