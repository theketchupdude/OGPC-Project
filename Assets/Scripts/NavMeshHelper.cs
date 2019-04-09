using UnityEngine;
using UnityEngine.AI;

public class NavMeshHelper : MonoBehaviour
{
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();

        NavMeshHit closestHit;

        if (NavMesh.SamplePosition(gameObject.transform.position, out closestHit, 500f, NavMesh.AllAreas))
        {
            gameObject.transform.position = closestHit.position;
            agent.enabled = true;
        }
        else
            Debug.LogError("Could not find position on NavMesh!");
    }
}
