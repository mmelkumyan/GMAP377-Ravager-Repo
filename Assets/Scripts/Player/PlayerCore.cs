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

    [NonSerialized]
    public PlayerArms arms;
    
    // [NonSerialized]
    public Transform cam;
    // public PlayerCamera camera;
    
    // TODO: Move to PlayerCamera
    [NonSerialized]
    public Boolean leftAiming = false;
    [NonSerialized]
    public Boolean rightAiming = false;

    private void Awake() {
	    // rb = GetComponent<Rigidbody>();  // FIXME: Returning null for some reason?
	    core = GetComponent<PlayerCore>();
	    movement = GetComponent<PlayerMovement>();
	    controller = GetComponent<PlayerInput>();
	    arms = GetComponent<PlayerArms>();
    }
}
