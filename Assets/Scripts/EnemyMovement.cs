using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    int MaxDist = 10;
    int MinDist = 30;

    //public GameObject Player;
    public Transform Player;

    public float movementSpeed = 4;
    void Update()
    {

        if (Vector3.Distance(transform.position, Player.position) <= MinDist)
        {
            transform.LookAt(Player.transform);

            transform.position += transform.forward * movementSpeed * Time.deltaTime;

        }



        Debug.Log(Vector3.Distance(transform.position, Player.position));


    }
}

