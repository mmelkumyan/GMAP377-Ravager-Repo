using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCore : MonoBehaviour
{
    // [NonSerialized]
    public Rigidbody rb;
	
    [NonSerialized] public PlayerMovement movement;
    
    [NonSerialized] public PlayerInput controller;

    public GameObject cameraFollowTarget;

    [NonSerialized] public PlayerArms arms;
    
    [NonSerialized] public PlayerCamera cam;

    public Transform camTransform;

    private void Awake() {
	    // rb = GetComponent<Rigidbody>();  // FIXME: Returning null for some reason?
	    movement = GetComponent<PlayerMovement>();
	    controller = GetComponent<PlayerInput>();
	    arms = GetComponent<PlayerArms>();
	    cam = GetComponent<PlayerCamera>();
    }
}
