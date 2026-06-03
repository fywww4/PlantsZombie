using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttacking : MonoBehaviour
{
    float last = 0;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Plant")
        {
            GetComponent<Animator>().SetTrigger("IsAttacking");
            if (Time.time - last >= 1)
            {
                coll.gameObject.GetComponent<Health>().doDamage(1);
                last = Time.time;
            }
        }
    }
}
