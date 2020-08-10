using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject EnemyBullet;
    public Transform firePoint;
    public float fireRate;
    private float nextFiretime;
    void Update()
    {
        if(Time.time> nextFiretime)
        {
            GameObject bullet = Instantiate(EnemyBullet, firePoint.position, Quaternion.identity);
            bullet.GetComponent<BulletMovement>().isPlayer = false;
            nextFiretime = Time.time + fireRate;
        } 
    }
}
