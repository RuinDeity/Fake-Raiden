using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed;
    public bool isPlayer;

    void Update()
    {
        if (isPlayer) {
            MoveUp();
        } else {
            MoveDown();
        }
    }

    void MoveUp() {
        Vector2 movement = Vector2.up * speed * Time.deltaTime;
        transform.Translate(movement);
        if (transform.position.y > 6) {
            Destroy(gameObject);
        }
    }

    void MoveDown() {
        Vector2 movement = Vector2.down * speed * Time.deltaTime;
        transform.Translate(movement);
        if (transform.position.y < -6) {
            Destroy(gameObject);
        }
    }
}
