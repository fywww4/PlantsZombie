using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunCollect : MonoBehaviour
{
    public static int scoure = 100;

    void OnMouseDown()
    {
        scoure += 20;

        Destroy(gameObject);
    }
}
