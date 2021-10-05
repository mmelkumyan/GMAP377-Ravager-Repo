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
        
        playerControls.Gameplay.Punch.performed += ctx => core.arms.Punch();
        
        playerControls.Gameplay.LeftAim.performed += ctx => core.leftAiming = true;
        playerControls.Gameplay.LeftAim.canceled += ctx => core.leftAiming = false;
        playerControls.Gameplay.RightAim.performed += ctx => core.rightAiming = true;
        playerControls.Gameplay.RightAim.canceled += ctx => core.rightAiming = false;
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
    
    // Interface approach. Leaving this here; might come back to it?
    //      Implements: PlayerControls.IGameplayActions
    /*
    private PlayerCore core;
    private PlayerControls playerControls;
    
    private Vector2 moveInputDirection;
    private Vector2 aimInputDirection;
    
    private void Awake() {
        core = GetComponent<PlayerCore>();
        playerControls = new PlayerControls();
        playerControls.Gameplay.SetCallbacks(this);
    }
    
    private void OnEnable() {
        playerControls.Gameplay.Enable();
    }

    private void OnDisable() {
        playerControls.Gameplay.Disable();
    }

    public void OnMove(InputAction.CallbackContext context) {
        if (!context.performed) return;
        moveInputDirection = playerControls.Gameplay.Move.ReadValue<Vector2>();
        core.movement.MovePlayer(moveInputDirection);
    }

    public void OnRise(InputAction.CallbackContext context) {
        if (!context.performed) return;
        core.movement.Rise();
    }

    public void OnSink(InputAction.CallbackContext context) {
        if (!context.performed) return;
        core.movement.Sink();
    }

    public void OnLook(InputAction.CallbackContext context) {
        if (!context.performed) return;
        aimInputDirection = playerControls.Gameplay.Look.ReadValue<Vector2>();
        core.movement.AimPlayer(aimInputDirection);
    }

    public void OnRightAim(InputAction.CallbackContext context) {
        if (!context.performed) return;
        core.rightAiming = true;
    }

    public void OnLeftAim(InputAction.CallbackContext context) {
        if (!context.performed) return;
        core.leftAiming = true;
    }

    public void OnPunch(InputAction.CallbackContext context) {
        if (!context.performed) return;
        core.arms.Punch();
    }

    public void OnTest(InputAction.CallbackContext context) {
        throw new NotImplementedException();
    }*/
}
