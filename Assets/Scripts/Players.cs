using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    //Boolean to check if Player1 is ON
    public bool player1;

    //Public initial Speed for the Players
    public float speed = 3;

    //Public rigidbody to interact with the ball and it's limits
    public Rigidbody2D rb;

    //Variable to save the input value for the player
    private float move;

    //Initialize Start Position for the Player
    private Vector2 startPos;



    // Start is called before the first frame update
    void Start()
    {
        //Define the start position for the Player
        startPos = transform.position;  
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the input is for Player1
        if(player1)
        {
            move = Input.GetAxis("Vertical");
        }
        //Check if the input is for Player2
        else
        {
            move = Input.GetAxis("Vertical2");
        }
        //Set velocity for the rigidboy of the Player according to its input*speed
        rb.velocity = new Vector2(rb.velocity.x, move*speed);
    }

    //Method to reset Player velocity and its position
    public void Reset()
    {
        //Setting rigidbody paddle velocity to zero
        rb.velocity = Vector2.zero;
        
        //Updating paddle position with start position on Goal
        transform.position = startPos;
    }

}
