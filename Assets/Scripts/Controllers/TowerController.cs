using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float rotationSpeed = 35;

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
    }

    void OnTriggerEnter(Collider co)
    {
        if (co.GetComponent<MonsterManager>())
        {
            GameObject g = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            g.GetComponent<BulletController>().target = co.transform;
        }
    }
}
