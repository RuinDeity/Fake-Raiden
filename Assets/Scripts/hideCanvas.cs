using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideCanvas : MonoBehaviour
{
    private Canvas canvas;
    void Awake()
    {
        canvas = GetComponent<Canvas>();
    }
    private void Start()
    {
        canvas.enabled = false;
    }

}
