using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDirection : MonoBehaviour {

    bool up;
    bool down;
    bool left;
    bool right;

    float X;
    float Y;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        X = Input.GetAxisRaw("Horizontal");
        Y = Input.GetAxisRaw("Vertical");

        if (X >= 0.5)
        {
            right = true;
            left = false;
        }
        else if (X >= 0.5 && Y == 0)
        {
            right = false;
            left = true;
            up = false;
            down = false;
        }

        if (X <= -0.5)
        {


        }
        else if (X <= -0.5 && Y == 0)
        {


        }

    }

}
