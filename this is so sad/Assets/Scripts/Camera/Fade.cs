using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour {

    public bool FadeIn = false;
    public bool FadeOut = false;
    
    public float FadeRate = 1;
  

	// Update is called once per frame
	void Update () {

        

        if (FadeIn == true)
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, GetComponent<SpriteRenderer>().color.a + FadeRate);

            if(GetComponent<SpriteRenderer>().color.a >= 1)
            {
                FadeIn = false;
            }
        }

        if(FadeOut == true)
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, GetComponent<SpriteRenderer>().color.a - FadeRate);

            if(GetComponent<SpriteRenderer>().color.a <= 0)
            {
                FadeOut = false;
                
            }
        }
        Debug.Log(GetComponent<SpriteRenderer>().color.a);
    }




}
