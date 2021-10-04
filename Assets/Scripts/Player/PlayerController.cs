using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerCore core;

    private PlayerControls controls;
    
    Vector2 moveInputDirection;
    Vector2 aimInputDirection;


    private void Awake() {
        core = GetComponent<PlayerCore>();

        controls = new PlayerControls();

        controls.Gameplay.Rise.performed += ctx => core.movement.Rise();
        controls.Gameplay.Sink.performed += ctx => core.movement.Sink();
        
        controls.Gameplay.Move.performed += ctx => moveInputDirection = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => moveInputDirection = Vector2.zero;
    }

    private void FixedUpdate() {
        core.movement.MovePlayer(moveInputDirection);
    }

    private void OnEnable() {
        controls.Gameplay.Enable();
    }

    private void OnDisable() {
        controls.Gameplay.Disable();

    }
}
