using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerArms : MonoBehaviour
{
    public Animator leftAnimator;
    public Animator rightAnimator;

    private PlayerCore core;

    private void Awake() {
        core = GetComponent<PlayerCore>();
    }

    public void Punch() {
        if (core.camera.leftAiming || !(core.camera.leftAiming || core.camera.rightAiming)) {
            PunchLeft();
        }
        if (core.camera.rightAiming || !(core.camera.leftAiming || core.camera.rightAiming)) {
            PunchRight();
        }

        Debug.Log("Punch!");
    }

    private void PunchLeft() {
        leftAnimator.SetTrigger("Punch");
    }

    private void PunchRight() {
        rightAnimator.SetTrigger("Punch");
    }

}
