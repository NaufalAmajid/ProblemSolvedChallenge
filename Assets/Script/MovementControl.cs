using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{   
    public Rigidbody2D rigidbody2D;

    public float speed = 10.0f;

    public KeyCode upButton = KeyCode.UpArrow;
    public KeyCode downButton = KeyCode.DownArrow;
    public KeyCode rightButton = KeyCode.RightArrow;
    public KeyCode leftButton = KeyCode.LeftArrow;
    
    // Update is called once per frame
    void Update()
    {   
        Vector2 velocity = rigidbody2D.velocity;

        if(Input.GetKey(upButton))
        {

            velocity.y = speed;
            
        }else if(Input.GetKey(downButton)){
            
            velocity.y = -speed;

        }else if(Input.GetKey(rightButton)){
            
            velocity.x = speed;

        }else if(Input.GetKey(leftButton)){
            
            velocity.x = -speed;

        }else{
            
            velocity.y = 0.0f;

            velocity.x = 0.0f;

        }
        
        rigidbody2D.velocity = velocity;

    }

}
