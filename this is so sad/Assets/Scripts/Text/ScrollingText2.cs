using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingText2 : MonoBehaviour {

    public Text UI_Text;
    public GameObject UIElement;

    public string SentText;
    public float TimeBetweenCharacters;

    public bool Writing;

    public int CurrentCharacter = 0;

    public float Timer = 0;

    string PrintedText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        UI_Text.text = SentText.Substring(0, CurrentCharacter);
        Timer = Timer + Time.deltaTime;

        if (Writing == true)
        {
            UIElement.SetActive(true);

            if (TimeBetweenCharacters <= Timer)
            {
                Timer = 0;
                CurrentCharacter = CurrentCharacter + 1;

                // UI_Text.text = SentText.Substring(0, CurrentCharacter);


                if (CurrentCharacter >= SentText.Length)
                {
                    Writing = false;
                    CurrentCharacter = SentText.Length;
                    
                }


            }else if (Input.GetButtonDown("Interact"))
                {
                    Writing = false;
                CurrentCharacter = SentText.Length;
                }

        } else if (Writing == false && Input.GetButtonDown("Interact"))
        {
          UIElement.SetActive(false);
            CurrentCharacter = 0;

            GetComponent<Movement>().LockMovement = false;
            GetComponent<MovementAnimation>().LockMovement = false;
        }


	}
}
