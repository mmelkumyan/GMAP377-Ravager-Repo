using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmTipController : MonoBehaviour
{
    private PlayerControls playerControls;
    private Rigidbody rb;
    private Vector2 moveInputDirection;
    
    public float speed = 5f;
    public float deceleration = 10f;

    private void Awake() {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody>();
    }

    private void Start() {
        
        playerControls.Gameplay.Rise.performed += ctx => Debug.Log("Test");

    }

    private void FixedUpdate() {
        moveInputDirection = playerControls.Gameplay.Move.ReadValue<Vector2>();
        Move(moveInputDirection);
    }

    void Move(Vector2 moveDir) {
        if (moveDir.magnitude > 0.1) {
            // Vector3 forwardMove = moveDir.y * transform.forward;
            // Vector3 lateralMove = moveDir.x * transform.right;
            // rb.velocity = (forwardMove + lateralMove) * speed;

            float dx = moveDir.x * speed * Time.deltaTime;
            float dy = moveDir.y * speed * Time.deltaTime;

            rb.position += new Vector3(dy, 0, -dx);

        }
        else {  // Stop moving -> decelerate to zero in currentDir
            rb.velocity = Vector3.Lerp(rb.velocity,  Vector3.zero, deceleration * Time.deltaTime);
        }
    }
    
    private void OnEnable() {
        playerControls.Gameplay.Enable();
    }

    private void OnDisable() {
        playerControls.Gameplay.Disable();
    }
}
