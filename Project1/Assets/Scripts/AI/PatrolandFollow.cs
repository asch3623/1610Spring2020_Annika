using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
[RequireComponent(typeof(NavMeshAgent))]
public class PatrolandFollow : MonoBehaviour
{

private NavMeshAgent agent;
public Transform player;
public float speed = 8f;

private Transform currentDestination;

public List<Transform> patrolPoints;
private int i;
private bool canHunt;

void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        currentDestination = transform;
    }

private void OnTriggerEnter(Collider other)
{
    canHunt = true;
    currentDestination = player;
}

private void OnTriggerExit(Collider other)
{
    currentDestination = transform;
    canHunt = false;
}

void Update()
{
    if (canHunt)
    {
        agent.destination = currentDestination.position;
        return;
    }
  
    if (!agent.pathPending && agent.remainingDistance < 0.5f)
    {
        agent.destination = patrolPoints[i].position;
        i = (i + 1) % patrolPoints.Count;
    }
}

// follows player all the time
// void Update(){
// agent.destination = player.position;
// }
}
