using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public int Life = 1;
    public int Points = 1;
    public GameManager gameManager;

    public void DealDamages()
    {
        Debug.Log("The enemy has been hit!");
        //reduce life
        Life--;
        //if life is under 0
        if (Life <= 0)
        {
            //kill the enemy and adds score
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.score += Points;
            Death();
            Debug.Log("The enemy has been killed.");
        }
    }

    //kill the enemy
    public void Death()
    {
        //destroy the enemy object
        Destroy(gameObject);
    }
}
