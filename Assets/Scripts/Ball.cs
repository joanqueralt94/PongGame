using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Public Ball speed
    public float speed = 7;

    //Public Ball rigidbody 
    public Rigidbody2D rb;

    //Start Ball position
    private Vector2 startPos;


    // Start is called before the first frame update
    void Start()
    {
        //Update Start Position with the initial position
        transform.position = startPos;
        
        //Start velocity and direction of the Ball
        Launch();
    }

    //Reset method when a player scores
    public void Reset()
    {
        //Update ball position to the Start Position
        transform.position = startPos;

        //Set vector velocity of the ball to zero
        rb.velocity = Vector2.zero;

        //Start velocity and direction of the Ball after a Reset
        Launch();
        
    }

    //Launch method as a starter ball direction and velocity
    public void Launch()
    {
        //Randomizing x and y direction to the Ball
        float x = Random.Range(0,2) == 0? -1 : 1;
        float y = Random.Range(0,2) == 0? -1 : 1;

        //Setting previous randomized velocity to the ball 
        rb.velocity = new Vector2(speed*x, speed*y);

    }
}
