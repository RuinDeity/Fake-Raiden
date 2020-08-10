using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class hitPlayer : MonoBehaviour
{
    public Pause pause;
    private void Awake()
    {
        pause = FindObjectOfType<Pause>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Time.timeScale = 0;
            pause.turnOnCanvas();
        }
    }
}
