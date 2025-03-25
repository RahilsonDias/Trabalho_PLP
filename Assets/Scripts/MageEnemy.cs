using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageEnemy : MonoBehaviour
{
    public Projectile projectilePrefab;

    public void CastSpell()
    {
        // Instantiate projectile at the parent object's position
        Projectile projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        // Set the projectile's initial position to be the same as the parent object
        projectile.transform.position = transform.position;
    }
}
