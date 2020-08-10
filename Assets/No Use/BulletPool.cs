using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public int size = 20;
    public GameObject bulletPerfab;
    private Queue<GameObject> bulletPool;
    public static BulletPool instance;

    private void Awake()
    {
        bulletPool = new Queue<GameObject>();

        for (int i = 0; i < size; i++)
        {
            GameObject bullet = Instantiate(bulletPerfab);
            bullet.SetActive(false);
            bulletPool.Enqueue(bullet);
        }
    }

    public void SpawnBullet(Vector2 position)
    {
        GameObject bullet = bulletPool.Dequeue();
        bullet.transform.position = transform.position;
        bullet.SetActive(true);
        bulletPool.Enqueue(bullet);
    }
}
