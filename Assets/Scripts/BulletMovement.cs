using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed;
    void Update()
    {
        Vector2 movement = Vector2.up * speed * Time.deltaTime;
        transform.Translate(movement);
        if (transform.position.y > 6 || transform.position.y < -6) {
            Destroy(gameObject);
        }
    }
}
