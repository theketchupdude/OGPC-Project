using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBase : MonoBehaviour 
{
    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;

    bool colliding = true;

    public float speed;

	// Use this for initialization
	void Start () 
    {
        agent = GetComponent<NavMeshAgent>();

        target = GameObject.Find("VR Rig").transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
        //float distance = Vector3.Distance(target.position, transform.position);

        //if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && colliding)
        {
            collision.gameObject.GetComponent<Player>().health -= 10;
            agent.isStopped = true;
            colliding = false;
            StartCoroutine(WaitAndResume());
        }
        if (collision.gameObject.tag == "EnemyDamager")
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator WaitAndResume()
    {
        yield return new WaitForSeconds(2);
        agent.isStopped = false;
        colliding = true;
    }
}
