using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;

    private void Update() {
        shootBullet();
    }

    public void shootBullet() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject Bullet =Instantiate(bullet, firePoint.position, transform.rotation);
        }
    }
}
