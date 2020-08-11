using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
    private Pause canvas;

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Player")
        {
            Time.timeScale = 0;
            canvas = GameObject.FindObjectOfType<Pause>();
            canvas.turnOnCanvas();
        }
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
