using System.Collections;
using System.Collections.Generic;
using DataTypes;
using UnityEngine;
[RequireComponent(typeof(Transform))]
public class KillScript : MonoBehaviour
{
    public FloatData killCheck; 
    Transform player;
    public Transform spawnPoint;
    public Vector3Data checkPointPos;
    public IntData health;

    void Start()
    {
           player = GetComponent<Transform>();
    }
    void Update()
    {

        if (killCheck.value <= -0.1)
        {
            player.transform.position = checkPointPos.value;
            print("I teleported");
            killCheck.value += 1;
            health.value--;
        }

        if (health.value == 0)
        {
            gameObject.SetActive(false);
        }
    }
}
