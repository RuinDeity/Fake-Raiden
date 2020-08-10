using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject EnemyBullet;
    public float nextFiretime;
    private float temp = 0.0f;
    void Update()
    {
        if(Time.time - temp > nextFiretime)
        {
            Instantiate(EnemyBullet, transform.position, Quaternion.identity);
            temp = Time.time;
        } 
    }
}
