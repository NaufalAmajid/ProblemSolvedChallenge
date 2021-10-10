using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingControl : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;

    public float x;
    public float y;

    void Start()
    {
        
        rigidbody2D = GetComponent<Rigidbody2D>();

        Invoke("Bouncing", 0);

    }

    void Bouncing(){

        float RandomDirection = Random.Range(0, 2);

        if (RandomDirection < 1.0f)
        {
            rigidbody2D.AddForce(new Vector2(-x, y));
        
        }else{
            
            rigidbody2D.AddForce(new Vector2(x, y));

        }

    }

}
