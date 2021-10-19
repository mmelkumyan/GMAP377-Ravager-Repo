using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeSpawn : MonoBehaviour
{
    [SerializeField] private GameObject partPrefab, parentObject;
    
    [SerializeField] [Range(1, 100)] private int length = 1;

    [SerializeField] private float partDistance = 0.21f;

    [SerializeField] private bool reset, spawn, snapFirst, snapLast;

    private void Update() {
        if (reset) {
            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Rope")) {
                Destroy(obj);
            }
        }
        
        if (spawn) {
            Spawn();
            spawn = false;
        }
    }

    public void Spawn() {
        int count = (int) (length / partDistance);

        for (int x = 0; x < count; x++) {
            GameObject tmp;
            Vector3 position = transform.position;
            position.y += partDistance * (x+1);
            
            tmp = Instantiate(partPrefab, position, Quaternion.identity, parentObject.transform);
            tmp.transform.eulerAngles = new Vector3(180, 0, 0);
            
            tmp.name = parentObject.transform.childCount.ToString();
            
            if (x == 0) {
                Destroy(tmp.GetComponent<CharacterJoint>());
                if (snapFirst) {
                    tmp.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                }
            }
            else {
                tmp.GetComponent<CharacterJoint>().connectedBody = parentObject.transform.Find((parentObject.transform.childCount - 1).ToString()).GetComponent<Rigidbody>();
            }
        }

        if (snapLast) {
            parentObject.transform.Find((parentObject.transform.childCount).ToString()).GetComponent<Rigidbody>()
                .constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
