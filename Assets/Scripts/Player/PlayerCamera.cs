using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public PlayerCore core;
	   
    public float followSpeed = 5f;
    public Vector3 cameraOffset;
	   
    private void LateUpdate() {
        Vector3 pos = core.transform.position;
        Vector3 targetPos = new Vector3(pos.x + cameraOffset.x, pos.y + cameraOffset.y, pos.z + cameraOffset.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * followSpeed);
    }
}
