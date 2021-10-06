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
        if (core.leftAiming || !(core.leftAiming || core.rightAiming)) {
            leftAnimator.SetTrigger("Punch");
        }
        if (core.rightAiming || !(core.leftAiming || core.rightAiming)) {
            rightAnimator.SetTrigger("Punch");
        }

        Debug.Log("Punch!");
    }

}
