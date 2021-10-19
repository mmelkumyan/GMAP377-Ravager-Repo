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
            
            // float vx = moveDir.x * speed;
            // float vy = moveDir.y * speed;

            // rb.position += new Vector3(0, dy, dx);
            // rb.velocity = new Vector3(vy, 0, -vx);
            // transform.position += new Vector3(dy, 0, -dx);
            
            rb.MovePosition( rb.position + new Vector3(dy, 0, -dx));
            // rb.MovePosition(new Vector3(0, dy, dx));
            
            // TODO: use RIGID BODY MOVEMENT for tip
        }
        else {  // Stop moving -> decelerate to zero in currentDir
            rb.velocity = Vector3.Lerp(rb.velocity,  Vector3.zero, deceleration * Time.deltaTime);
        }
    }
    
    // NOTE: The key is making the arm tip KINEMATIC! make the target point mesh off.
    
    private void OnEnable() {
        playerControls.Gameplay.Enable();
    }

    private void OnDisable() {
        playerControls.Gameplay.Disable();
    }
}
