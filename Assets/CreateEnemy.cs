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
        System.Random a = new System.Random();
        int number = a.Next(-10,10);
        Vector2 CreatePlace;
        CreatePlace.x = number;
        CreatePlace.y = transform.position.y;
        if (Time.time - temp > CreateTime)
        {
            Instantiate(Enemy, CreatePlace, Quaternion.identity);
            temp = Time.time;
        }
        
    }

}
