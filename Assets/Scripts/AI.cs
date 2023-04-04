using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    //Public AI paddle speed 
    public float speed = 3;

    //Ball reference
    public GameObject ball;
    
    //Ball position
    private Vector2 ballPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Update ball movement on Update
        Move();
    }

    void Move()
    {
        //Update ball position
        ballPos = ball.transform.position;

        //Comparison from AI paddle position with ball position and its correction
        if(transform.position.y > ballPos.y)
        {
            //Update paddle position with Ball position going down
            transform.position += new Vector3(0,-speed*Time.deltaTime);
        }
        else if(transform.position.y < ballPos.y)
        {
            //Update paddle position with Ball position going up
            transform.position += new Vector3(0,speed*Time.deltaTime);
        }
    }
}
