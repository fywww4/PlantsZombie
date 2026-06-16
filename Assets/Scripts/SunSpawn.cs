using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSpawn : MonoBehaviour
{
    public GameObject sunPrefab;

    void Start()
    {
        InvokeRepeating("Spawn", 2, 2);
    }

    void Spawn()
    {
        Instantiate(sunPrefab, transform.position, Quaternion.identity);
    }
}
