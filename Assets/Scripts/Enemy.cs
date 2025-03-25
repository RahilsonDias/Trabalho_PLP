using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour, IEnemy
{
    public Projectile projectilePrefab;
    public int fireRate;
    int count = 0;

    /*public void Update()
    {
        count++;
        if (count >= fireRate)
        {
            Attack();
            count = 0;
        }
    }*/
    public void Attack()
    {
        // Instantiate projectile at the parent object's position
        Projectile projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        // Set the projectile's initial position to be the same as the parent object
        projectile.transform.position = transform.position;
    }
}
