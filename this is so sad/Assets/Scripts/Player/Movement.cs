using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float HorizontalSpeed = 1;
    public float VerticalSpeed = 1;

    float X;
    float Y;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        X = Input.GetAxisRaw("Horizontal");
        Y = Input.GetAxisRaw("Vertical");

        if(X != 0 & Y != 0)
        {
           GetComponent<Rigidbody2D>().velocity = new Vector2((X * HorizontalSpeed), (Y * VerticalSpeed));
        }else if(X != 0){

            GetComponent<Rigidbody2D>().velocity = new Vector2((X * HorizontalSpeed), 0f);
        }else if(Y != 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, (Y * VerticalSpeed));
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f,0f);
        }
	}
}
