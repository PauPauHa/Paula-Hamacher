using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class EnemyMover : MonoBehaviour

{
    public Transform M_Player;


    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = M_Player.position;
    }
}
