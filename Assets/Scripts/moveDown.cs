using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDown : MonoBehaviour
{
    public float Screenspeed;

    void Update()
    {
        Vector2 movement = Vector2.up * Screenspeed * Time.deltaTime;
        transform.Translate(movement);
    }
}
