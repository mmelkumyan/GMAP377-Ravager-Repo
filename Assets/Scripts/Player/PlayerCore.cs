using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCore : MonoBehaviour
{
    public Rigidbody rb;
    
    [NonSerialized] public PlayerInput controller;
	
    [NonSerialized] public PlayerMovement movement;

    [NonSerialized] public PlayerStats stats;

    [NonSerialized] public PlayerArms arms;
    
    public GameObject cameraFollowTarget;
    
    [NonSerialized] public PlayerCamera cam;

    public Transform camTransform;

    private void Awake() {
	    // rb = GetComponent<Rigidbody>();  // FIXME: Returning null for some reason?
	    controller = GetComponent<PlayerInput>();
	    movement = GetComponent<PlayerMovement>();
	    stats = GetComponent<PlayerStats>();
	    arms = GetComponent<PlayerArms>();
	    cam = GetComponent<PlayerCamera>();
    }
}
