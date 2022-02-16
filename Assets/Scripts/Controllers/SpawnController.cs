using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] GameObject monsterPrefab;
    [SerializeField] float interval = 5;

    void Start()
    {
        InvokeRepeating("Spawn", interval, interval);
    }

    void Spawn()
    {
        Instantiate(monsterPrefab, transform.position, Quaternion.identity);
    }
}
