using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnnemyAI : MonoBehaviour
{

    private NavMeshAgent navMesh;
    public GameObject joueur;
    
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        navMesh.SetDestination(joueur.transform.position);
    }
}
