using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PlayerCamera : MonoBehaviour 
{
    public GameObject freeCamera;

    public GameObject aimCamera;
    
    [NonSerialized]
    public bool aiming = false;

    private PlayerCore core;

    private void Awake() {
        core = GetComponent<PlayerCore>();
    }

    private void Update() {
        if (aiming) {
            aimCamera.SetActive(true);
            freeCamera.SetActive(false);
        }
        else {
            aimCamera.SetActive(false);
            freeCamera.SetActive(true);
        }
    }
}
