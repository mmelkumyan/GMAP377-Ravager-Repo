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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Speed Up Item")
        {
            core.movement.maxSpeed += 10f;
            core.movement.acceleration += 300f;
            core.movement.deceleration += 10f;
            core.movement.rotationSpeed += 5f;
            core.movement.riseSpeed += 60f;
            core.movement.sinkSpeed += 60f;
            core.particleHolder.GetComponent<ParticleCore>().growAnim();
            Destroy(collision.gameObject);
            core.gameObject.transform.localScale += new Vector3(0.3f, 0.3f, 0.3f);
        }
    }
}
