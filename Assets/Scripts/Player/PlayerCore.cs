using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCore : MonoBehaviour
{

    [NonSerialized]
    public Rigidbody rigidbody;
	
    [NonSerialized]
    public PlayerCore core;
    
    [NonSerialized]
    public PlayerMovement movement;
    
    [NonSerialized]
    public PlayerController controller;

    
    // [NonSerialized]
    // public Camera cam;
    //
    // public PlayerCamera camera;


    private void Awake() {
	    // this.collider = this.GetComponent<CapsuleCollider>();
	    rigidbody = GetComponent<Rigidbody>();
	    core = GetComponent<PlayerCore>();
	    movement = GetComponent<PlayerMovement>();
	    controller = GetComponent<PlayerController>();
    }
}
