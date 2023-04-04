using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //Boolean to check if Player1Goal
    public bool player1Goal;

    //Reference to the Game Manager
    public GameManager gameManager;

    //Check Collision by Trigger
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //Check if the Collision received is from the Ball game object
        if(collision.CompareTag("Ball"))
        {
            //Check if the collision is with the Player 2 Goal
            if(player1Goal)
            {
                gameManager.GetComponent<GameManager>().Player1Scored();
            }

            //Check if the collision is with the Player 1 Goal
            else
            {
                gameManager.GetComponent<GameManager>().Player2Scored();
            }
        }
    }




}
