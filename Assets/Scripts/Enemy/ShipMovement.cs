using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] private Vector3[] positions;
    [SerializeField] private float shipDuration = 2f;
    [SerializeField] private float shipSpeed = 0.01f;

    private List<NavMeshAgent> agentsOnShip = new List<NavMeshAgent>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveShip());
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<NavMeshAgent>(out NavMeshAgent agent))
        {
            agentsOnShip.Add(agent);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<NavMeshAgent>(out NavMeshAgent agent))
        {
            agentsOnShip.Remove(agent);
        }
    }

    private IEnumerator MoveShip()
    {
        transform.position = positions[0];
        int positionIndex = 0;
        int lastPositionIndex;
        WaitForSeconds Wait = new WaitForSeconds(shipDuration);

        while (true)
        {
            lastPositionIndex = positionIndex;
            positionIndex++;
            if(positionIndex >= positions.Length)
            {
                positionIndex = 0;
            }

            Vector3 shipMoveDirection = (positions[positionIndex] - positions[lastPositionIndex]).normalized;
            float distance = Vector3.Distance(transform.position, positions[positionIndex]);
            float distanceTraveled = 0;

            while(distanceTraveled < distance)
            {
                transform.position += shipMoveDirection * shipSpeed;
                distance += shipMoveDirection.magnitude * shipSpeed;

                for(int i=0; i < agentsOnShip.Count; i++)
                {
                    agentsOnShip[i].destination += shipMoveDirection * shipSpeed;
                }

                yield return null;

            }

            yield return Wait;
        }
    }

}
