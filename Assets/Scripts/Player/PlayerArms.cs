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
        if (core.cam.leftAiming || !(core.cam.leftAiming || core.cam.rightAiming)) {
            PunchLeft();
        }
        if (core.cam.rightAiming || !(core.cam.leftAiming || core.cam.rightAiming)) {
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
