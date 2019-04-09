using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBase : MonoBehaviour 
{

    GameObject player;

    NavMeshAgent agent;

    public float speed;

	// Use this for initialization
	void Start () 
    {
        agent = GetComponent<NavMeshAgent>();

        player = GameObject.Find("VR Rig");
	}
	
	// Update is called once per frame
	void Update () 
    {
        agent.SetDestination(player.transform.position);
	}
}
