using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public float CreateTime;
    float temp;
    private void Update()
    {
        Create();
    }
    void Create()
    {
        float x = Random.Range(-9f,9f);
        Vector2 CreatePlace = new Vector2(x, transform.position.y);
        if (Time.time - temp > CreateTime)
        {
            Instantiate(Enemy, CreatePlace, Quaternion.Euler(new Vector3(0,0,180)));
            temp = Time.time;
        }
        
    }

}
