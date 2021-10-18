using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public NavMeshAgent agent;

    //Random Patrolling
    [Range(0, 100)] public float speed;
    [Range(1, 200)] public float roamRadius;


    public bool KrakenDetected = false;
    public Transform shipPart;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if(agent != null)
        {
            agent.speed = speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //When there's an agent
        if (agent != null)
        {
            //If the Kraken is not detected, patrol
            if (KrakenDetected == false && agent.remainingDistance <= agent.stoppingDistance)
            {
                agent.SetDestination(RandomNavMeshLocation());
            }
            //If the Kraken is detected, move pirate to their sector
            else if (KrakenDetected == true)
            {
                agent.SetDestination(shipPart.localPosition);
            }
            Debug.Log(KrakenDetected);

        }
    }

    public Vector3 RandomNavMeshLocation()
    {
        Vector3 finalPosition = Vector3.zero;
        Vector3 randomPosition = Random.insideUnitSphere * roamRadius;
        randomPosition += transform.position;
        if (NavMesh.SamplePosition(randomPosition, out NavMeshHit hit, roamRadius, 1))
        {
            finalPosition = hit.position;
        }
        return finalPosition;
    }

    public Vector3 PirateRoleLocation(GameObject shipPart)
    {
        Vector3 shipPartPosition;
        shipPartPosition = shipPart.transform.position;
        return shipPartPosition;
    }


}
