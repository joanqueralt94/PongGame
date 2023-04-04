using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
 
    public GameObject ball;
    public GameObject player1;
    public GameObject player2;
    public GameObject player1Goal;
    public GameObject player2Goal;

    public Text player1text;
    public Text player2text;

    private int player1Score;
    private int player2Score;

    public bool AIGame;
    
    public int maxScore = 3;


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

    public void Player1Scored()
    {
        player1Score++;
        player1text.text = player1Score.ToString();
        CheckVictory();
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2Score++;
        player2text.text = player2Score.ToString();
        CheckVictory();
        ResetPosition();
    }

    private void ResetPosition()
    {
        
        if(AIGame)
        {
            ball.GetComponent<Ball>().Reset();
            player2.GetComponent<Players>().Reset();
        }
        else
        {
            ball.GetComponent<Ball>().Reset();
            player1.GetComponent<Players>().Reset();
            player2.GetComponent<Players>().Reset();
        }

    }

}
