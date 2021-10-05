using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PlayerCamera : MonoBehaviour 
{
    public GameObject freeCamera;
    public GameObject leftAimCamera;
    public GameObject rightAimCamera;

    private PlayerCore core;

    private void Awake() {
        core = GetComponent<PlayerCore>();
    }

    private void Update() {
        if (core.leftAiming) {
            leftAimCamera.SetActive(true);
            freeCamera.SetActive(false);
            rightAimCamera.SetActive(false);
        }
        else if (core.rightAiming) {
            rightAimCamera.SetActive(true);
            freeCamera.SetActive(false);
            leftAimCamera.SetActive(false);
        }
        else {
            freeCamera.SetActive(true);
            leftAimCamera.SetActive(false);
            rightAimCamera.SetActive(false);
        }
    }
}
