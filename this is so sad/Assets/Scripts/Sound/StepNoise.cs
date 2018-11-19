using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepNoise : MonoBehaviour {

    float X;
    float Y;
    float timer;
    public float StepTime = 0.5f;
    
    bool Shutup = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        X = Input.GetAxisRaw("Horizontal");
        Y = Input.GetAxisRaw("Vertical");


        if((X != 0 || Y != 0)& Shutup == false)
        {
        timer += Time.deltaTime;
            if (timer >= StepTime)
            {
                GetComponent<AudioSource>().Play(0);
                timer = 0f;
            }
        }
        else
        {
            timer = StepTime;
            GetComponent<AudioSource>().Stop();
        }
    }
}
