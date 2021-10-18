using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShipController : MonoBehaviour
{

    public Transform target;
    NavMeshAgent agent;

    FieldOfView fov;
    public bool KrakenDetected;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        KrakenDetected = fov.canSeePlayer;
        if(KrakenDetected == true)
        {
            followKraken();
        }
    }

    private void followKraken()
    {
        agent.SetDestination(target.position);
    }
}
