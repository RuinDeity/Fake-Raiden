﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleLeft : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKey(KeyCode.A))
            {
               
            }
        }
    }
}
