using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
     void OnMouseUpAsButton()
     {
        if (BuildMenu.cur != null)
        {
            Instantiate(BuildMenu.cur.gameObject, transform.position, Quaternion.identity);
            SunCollect.scoure -= BuildMenu.cur.price;
            BuildMenu.cur = null;
        }
     }
}
