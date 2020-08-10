using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed;
    void Update()
    {
        move();
    }

    public void move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 dir = Vector2.right * x + Vector2.up * y;
        Vector2 movement = dir * speed * Time.deltaTime;
        transform.Translate(movement);
        float xPos = transform.position.x;
        float yPos = transform.position.y;
        xPos = Mathf.Clamp(xPos, -9, 9);
        yPos = Mathf.Clamp(yPos, -5, 5);
        transform.position = new Vector2(xPos,yPos);
        transform.position = new Vector2(xPos,yPos);
    }
}

