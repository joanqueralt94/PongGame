using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public void Player1Scored()
    {
        player1Score++;
        player1text.text = player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2Score++;
        player2text.text = player2Score.ToString();
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
