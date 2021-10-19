using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeInitializer : MonoBehaviour
{
    private void Start() {
        GetComponent<CharacterJoint>().connectedBody = transform.parent.GetComponent<Rigidbody>();
    }
}
