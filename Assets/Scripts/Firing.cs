using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float interval = 0.5f;

    void Start()
    {
        InvokeRepeating("Shoot", 0, interval);
    }

    void Shoot()
    {
        if (zombieInFront())
        {
            GetComponent<Animator>().SetTrigger("IsFiring");

            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }

    bool zombieInFront()
    {
        Vector2 origin = new Vector2(9.5f, transform.position.y);
        RaycastHit2D[] hits = Physics2D.RaycastAll(origin, -Vector2.right);

        foreach (RaycastHit2D hit in hits)
        {
            if (hit.collider != null &&
                hit.collider.gameObject.tag == "Zombie")
                return true;
        }
        return false;
    }
}
