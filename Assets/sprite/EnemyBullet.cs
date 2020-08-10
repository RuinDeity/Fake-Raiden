using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed;
    void Update()
    {
        Vector2 movement = Vector2.down * speed * Time.deltaTime;
        transform.Translate(movement); 
    }
}
