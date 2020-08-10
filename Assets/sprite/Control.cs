using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed;
    public GameObject PlayerBullet;
    void Update()
    {
        move();
        shootBullet();
    }

    public void move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 movement = Vector2.right * speed * Time.deltaTime;
            if (transform.position.x +  movement.x > 10) {
                return;
            }
            transform.Translate(movement);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector2 movement = Vector2.left * speed * Time.deltaTime;
            if (transform.position.x + movement.x < -10)
            {
                return;
            }
            transform.Translate(movement);
        }

        if (Input.GetKey(KeyCode.W))
        {
            Vector2 movement = Vector2.up * speed * Time.deltaTime;
            if (transform.position.y + movement.y > 5)
            {
                return;
            }
            transform.Translate(movement);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector2 movement = Vector2.down * speed * Time.deltaTime;
            if (transform.position.y + movement.y < -5)
            {
                return;
            }
            transform.Translate(movement);
        } 
    }



    public void shootBullet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(PlayerBullet, transform.position, Quaternion.identity);
        }
    }
}

