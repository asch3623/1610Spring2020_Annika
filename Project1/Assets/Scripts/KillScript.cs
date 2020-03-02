using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Transform))]
public class KillScript : MonoBehaviour
{
    public FloatData killCheck; 
    Transform player;
    public Transform spawnPoint;

    void Start()
    {
           player = GetComponent<Transform>();
    }
    void Update()
    {

        if (killCheck.value <= -0.1)
        {
            player.transform.position = spawnPoint.transform.position;
            print("I teleported");
            killCheck.value += 1;
        }
    }
}
