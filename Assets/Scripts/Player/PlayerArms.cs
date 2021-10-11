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

    public void PunchLeft() {
        leftAnimator.SetTrigger("Punch");
    }

    public void PunchRight() {
        rightAnimator.SetTrigger("Punch");
    }

}
