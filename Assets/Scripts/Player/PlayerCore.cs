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
    
    public Transform camTransform;
    [NonSerialized]
    public PlayerCamera cam;

    private void Awake() {
	    // rb = GetComponent<Rigidbody>();  // FIXME: Returning null for some reason?
	    core = GetComponent<PlayerCore>();
	    movement = GetComponent<PlayerMovement>();
	    controller = GetComponent<PlayerInput>();
	    arms = GetComponent<PlayerArms>();
	    cam = GetComponent<PlayerCamera>();
    }
}
