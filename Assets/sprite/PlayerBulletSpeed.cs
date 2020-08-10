using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletSpeed : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector2 movement = Vector2.up * speed * Time.deltaTime;
        transform.Translate(movement);
    }


}
