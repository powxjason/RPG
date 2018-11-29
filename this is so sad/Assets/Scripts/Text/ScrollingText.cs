using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingText : MonoBehaviour {

    public string Text;
    public Text UI_Text;
    public GameObject UIElement;

    [Range(0.01f,5)]
    public float timerLeg;

    float timer;
    string LocalText;
    public bool isTyping, textComplete;
    public int textLeg;
    public int printLeg;

    int chraracters;
	
	// Update is called once per frame
	void Update () {

        

        if (isTyping)
        {
        timer += Time.deltaTime;

        }

        if (Input.GetButtonDown("Interact") && isTyping)
        {
            LocalText = Text;
        }
        else if (Input.GetButtonDown("Interact") && textComplete)
        {
            Text = "";
            LocalText = Text;
            isTyping = false;
            textComplete = false;
            UIElement.SetActive(false);
        }



        if (isTyping)
        {
            timer += Time.deltaTime;

            if (timer >= timerLeg)
            {
                chraracters += 1;
                timer = 0;
                UI_Text.text = LocalText[chraracters].ToString();
                if (printLeg >= textLeg)
                {
                    isTyping = false;
                    textComplete = true;
                }
            }
          
        }

    }
   

    public void Type(string text)
    {
        UIElement.SetActive(true);
        timer = 0;


        isTyping = true;
        int i = 0;
        while (i < text.Length)
        {
            timer += Time.deltaTime;

            if (timer >= timerLeg)
            {
                LocalText = LocalText + text[i];
                i++;
                timer = 0;
            }
            if (i >= text.Length)
            {
                isTyping = false;
                textComplete = true;
                break;

            }
        }
    }

}

