using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCore : MonoBehaviour
{

    // [NonSerialized]
    public Rigidbody rb;
	
    [NonSerialized]
    public PlayerCore core;
    
    [NonSerialized]
    public PlayerMovement movement;
    
    [NonSerialized]
    public PlayerInput controller;

    public GameObject cameraFollowTarget;
    
    // [NonSerialized]
    public Transform cam;
    // public PlayerCamera camera;


    private void Awake() {
	    // rb = GetComponent<Rigidbody>();  // FIXME: Returning null for some reason?
	    core = GetComponent<PlayerCore>();
	    movement = GetComponent<PlayerMovement>();
	    controller = GetComponent<PlayerInput>();
    }
}
