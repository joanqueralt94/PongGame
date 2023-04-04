using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Gameobjects references for the Game Manager
    public GameObject ball;
    public GameObject player1;
    public GameObject player2;
    public GameObject player1Goal;
    public GameObject player2Goal;

    //Player1 and Player2 text to string (SCORE)
    public Text player1text;
    public Text player2text;

    //Int number for Player1 and Player2
    private int player1Score;
    private int player2Score;

    //Boolean variable to determine if AI gamemode
    public bool AIGame;
    
    //Constant to set max Score of any Game Mode
    public const int maxScore = 3;

    //Method to determine on Victory condition
    public void CheckVictory()
    {
        //Check Victory in the AI Game Mode
        if(AIGame)
        {
            if(player1Score >= maxScore)
            {
            //Player 1 Wins
            SceneManager.LoadScene("VictoryPlayerAI");

            }
            else if (player2Score >= maxScore)
            {
            //Player 2 Wins
            SceneManager.LoadScene("VictoryPlayer1");
            }
        }
        
        //Check Victory in the Player vs Player Game Mode
        else
        {
            if(player1Score >= maxScore)
            {
                //Player 1 Wins
                SceneManager.LoadScene("VictoryPlayer2");
            }
            else if (player2Score >= maxScore)
            {
                //Player 2 Wins
                SceneManager.LoadScene("VictoryPlayer1");
            }
        }
        
    }

    //Method when Player1 has scored
    public void Player1Scored()
    {
        //Increment Player1 score with 1
        player1Score++;
        //Update Player1 text with the new value (added above)
        player1text.text = player1Score.ToString();
        //Check if Player1 has already won
        CheckVictory();
        //Reset Ball, Player1 and Player2 position and velocities
        ResetPosition();
    }

    //Method when Player2 has scored
    public void Player2Scored()
    {
        //Increment Player2 score with 1
        player2Score++;
        //Update Player2 text with the new value (added above)
        player2text.text = player2Score.ToString();
        //Check if Player2 has already won
        CheckVictory();
        //Reset Ball, Player1 and Player2 position and velocities
        ResetPosition();
    }

    //Method to Reset Position for every actor in the game
    private void ResetPosition()
    {
        //Check if the actual Game Mode is AI
        if(AIGame)
        {
            //Reseting ball position
            ball.GetComponent<Ball>().Reset();
            //Reseting AI player position
            player2.GetComponent<Players>().Reset();
        }
        //Check if the actual game mode is Player vs Player
        else
        {
            //Reseting ball position
            ball.GetComponent<Ball>().Reset();
            //Reseting Player1 position
            player1.GetComponent<Players>().Reset();
            //Reseting Player2 position
            player2.GetComponent<Players>().Reset();
        }

    }

}
