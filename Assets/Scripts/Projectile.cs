using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float destroyTime;

    void Start()
    {
        // Set the projectile to destroy itself after a certain time
        Destroy(gameObject, destroyTime);
    }

    void Update()
    {
        // Move the projectile forward
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
