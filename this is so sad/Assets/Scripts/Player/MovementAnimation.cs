using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnimation : MonoBehaviour {

    public bool LockMovement;

    float X;
    float Y;

    string Locked = "None";
    float XL;
    
    float YL;
    int last;
    
	// Update is called once per frame
	void Update () {
        X = Input.GetAxisRaw("Horizontal");
        Y = Input.GetAxisRaw("Vertical");

        if (!LockMovement)
        {
            if (X != 0 & Y != 0)
            {
                if (Y >= 0.5 & Locked == "None")
                {
                    Locked = "Up";
                    YL = -1;
                }
                if (Y <= 0.5 & Locked == "None")
                {
                    Locked = "Down";
                    YL = 1;
                }
            }
            else if (X != 0)
            {
                if (X >= 0.5 & Locked == "None")
                {
                    Locked = "Right";
                    XL = -1;
                }
                if (X <= 0.5 & Locked == "None")
                {
                    Locked = "Left";
                    XL = 1;
                }

            }
            else if (Y != 0)
            {
                if (Y >= 0.5 & Locked == "None")
                {
                    Locked = "Up";
                    YL = -1;
                }
                if (Y <= 0.5 & Locked == "None")
                {
                    Locked = "Down";
                    YL = 1;
                }
            }
            if (((Locked == "Up" || Locked == "Down") & (Y == YL || Y == 0)) || ((Locked == "Right" || Locked == "Left") & (X == XL || X == 0)))
            {
                Locked = "None";
                YL = 0;
                XL = 0;
            }
            else if (X == 0 && Y == 0)
            {
                Locked = "None";
                YL = 0;
                XL = 0;
            }

            if (Locked == "Up")
            {
                GetComponent<Animator>().SetInteger("Animation", 1);
                GetComponent<SpriteRenderer>().flipX = false;
                last = 1;

            }
            else if (Locked == "Down")
            {
                GetComponent<Animator>().SetInteger("Animation", 2);
                GetComponent<SpriteRenderer>().flipX = false;
                last = 2;
            }
            else if (Locked == "Left")
            {
                GetComponent<Animator>().SetInteger("Animation", 3);
                GetComponent<SpriteRenderer>().flipX = true;
                last = 3;
            }
            else if (Locked == "Right")
            {
                GetComponent<Animator>().SetInteger("Animation", 3);
                GetComponent<SpriteRenderer>().flipX = false;
                last = 3;
            }
            else
            {
                if (last == 3)
                {
                    GetComponent<Animator>().SetInteger("Animation", 0);
                    last = 0;
                }
                else if (last == 2)
                {
                    GetComponent<Animator>().SetInteger("Animation", 5);
                    last = 5;
                }
                else if (last == 1)
                {
                    GetComponent<Animator>().SetInteger("Animation", 4);
                    last = 4;
                }


            }
        }
        else
        {

            if (last == 3)
            {
                GetComponent<Animator>().SetInteger("Animation", 0);
                last = 0;
            }
            else if (last == 2)
            {
                GetComponent<Animator>().SetInteger("Animation", 5);
                last = 5;
            }
            else if (last == 1)
            {
                GetComponent<Animator>().SetInteger("Animation", 4);
                last = 4;
            }
        }


    }
}
