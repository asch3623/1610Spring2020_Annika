using System.Collections;
using UnityEngine.AI;
using UnityEngine;
[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentBehavior : MonoBehaviour
{

private NavMeshAgent agent;
public Transform player;
public float speed = 8f;

void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
    }

    void Update()
    {
        agent.destination = player.position;
    }
}
