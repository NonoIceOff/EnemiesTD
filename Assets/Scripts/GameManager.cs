using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isPlaying = true; //set to false when player met win or loss conditions

    public float RemainingTime = 30f; //remaining time before the player win the game
    public Text timeValue; //text used to show remaining time to player

    public int score = 0; //points
    public Text scoreValue; //text used to show score to player

    public Text EndGameText; //text used to show the endgame message

    public Text scoreText; // text used to show the score

    public Text endGameText;

    public void PlayerIsDeadStopGame()
    {
        isPlaying = false;
        endGameText.text = "YOU LOOSE!";
    }

    public void PlayerWin()
    {
        isPlaying = false;
        endGameText.text = "YOU WIN!";
    }

    // Update is called once per frame
    void Update()
    {
        // if score text is present then update text
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
        }


        // if the game is in progress and there is still time to play
        if (isPlaying && RemainingTime > 0)
        {
            //reduce reamining time at each frame
            RemainingTime -= Time.deltaTime;

             // if time text is present then update text
            if (timeValue != null)
            {
                timeValue.text = RemainingTime.ToString();
            }

            //if the play time is over
            if (RemainingTime <= 0 && isPlaying)
            {
                PlayerWin();
            }
        }
    }
}
