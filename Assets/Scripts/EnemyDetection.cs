using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    // when a collider enters the bullet zone
   void OnTriggerEnter2D(Collider2D collision)
    {
        // when the collider is an enemy, give damage to the enemy
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.GetComponent<EnemyLife>().DealDamages();
        }
    }
}
