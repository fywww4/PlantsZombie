using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSpawn : MonoBehaviour
{
    public GameObject sunPrefab;

    void Start()
    {
        InvokeRepeating("Spawn", 10, 10);
    }

    void Spawn()
    {
        Instantiate(sunPrefab, transform.position, Quaternion.identity);
    }
}
