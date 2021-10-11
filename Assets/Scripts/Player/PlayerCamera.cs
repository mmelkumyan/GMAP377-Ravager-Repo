using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PlayerCamera : MonoBehaviour 
{
    public GameObject freeCamera;

    public GameObject aimCamera;
    public CinemachineFreeLook freeCam;
    
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

    public void ResetFreelookPos() {
        freeCam.m_YAxis.Value = 0.5f;
        // Sets x value to directly behind player
        float yRotation = transform.rotation.eulerAngles.y;
        freeCam.m_XAxis.Value = (yRotation < 180)
            ? yRotation- 360f
            : yRotation;
    }
}
