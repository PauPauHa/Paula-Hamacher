using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class EnemyMover : MonoBehaviour

{
    public Transform m_Player;


    // Update is called once per frame
    void Update()
    {
        // sorgt dafür das der enemy der transfrom componente des spielers folgt 
        GetComponent<NavMeshAgent>().destination = m_Player.position;
    }
}
