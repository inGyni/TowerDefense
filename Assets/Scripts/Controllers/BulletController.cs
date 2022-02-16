using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 1;
    public Transform target;
    EconomyManager em;

    private void Start()
    {
        em = GameObject.Find("EconomyManager").GetComponent<EconomyManager>();
    }

    void FixedUpdate()
    {
        if (target)
        {
            Vector3 dir = target.position - transform.position;
            GetComponent<Rigidbody>().velocity = dir.normalized * speed;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider co)
    {
        HealthManager hm = co.GetComponentInChildren<HealthManager>();
        if (hm)
        {
            hm.decrease();
            Destroy(gameObject);
            em.ModifyBalance(10);
        }
    }
}
