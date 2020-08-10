using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBoundary : MonoBehaviour
{
    public GameObject bullet;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
}
