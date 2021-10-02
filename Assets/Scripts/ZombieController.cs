using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        agent.updateUpAxis = false;
        agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
        Vector3 diff = agent.steeringTarget - agent.transform.position;
        diff = new Vector3(diff.x, diff.y, 0);
        this.transform.rotation = Quaternion.FromToRotation(Vector3.up, diff);
    }
}
