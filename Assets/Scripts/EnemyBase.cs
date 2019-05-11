using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBase : MonoBehaviour
{
    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;

    bool attacking = false;

    public float speed;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
        target = GameObject.Find("VR Rig").transform;
        agent.stoppingDistance = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        // If inside the lookRadius
        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position); // Move toward target

            // If within attacking distance
            if (distance <= agent.stoppingDistance)
            {
                if (!attacking)
                {
                    attacking = true;
                    target.gameObject.GetComponentInChildren<OVRstuff>().health -= 10;

                    FaceTarget(); // Make sure to face towards the target

                    StartCoroutine(WaitAndResume());
                }
            }
        }

    }

    // Rotate to always face target
    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "EnemyDamager")
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator WaitAndResume()
    {
        yield return new WaitForSeconds(2);
        attacking = false;
    }
}
