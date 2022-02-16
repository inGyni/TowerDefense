using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterManager : MonoBehaviour
{
    private Transform target;
    private NavMeshAgent agent;

    void Start()
    {
        target = GameObject.Find("Castle").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(target.position);
    }

    void OnTriggerEnter(Collider co)
    {
        if (co.CompareTag("Castle"))
        {
            co.GetComponentInChildren<HealthManager>().decrease();
            Destroy(gameObject);
        }
    }
}
