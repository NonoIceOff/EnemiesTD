using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public GameManager gameManager;
    public int Life = 3;
    public Text LifeValue;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if the colliding object is an enemy && and the game isn't over
        if (collision.gameObject.CompareTag("Enemy") && gameManager.isPlaying)
        {
            Debug.Log("The enemy has been hit and your life has been reduced!");
            //kill the enemy
            collision.gameObject.GetComponent<EnemyLife>().Death();
            //Reduce life
            Life--;
            if (Life <= 0)
            {
                //Kill the player
                Debug.Log("You are dead");
                LifeValue.text = Life.ToString();
                Death();
            }
        }
    }

    void Death()
    {
        //stop the game
        gameManager.PlayerIsDeadStopGame();
        //destroy the player object
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // if life text is present then update text
        if (LifeValue != null)
        {
            LifeValue.text = Life.ToString();
        }
    }
}
