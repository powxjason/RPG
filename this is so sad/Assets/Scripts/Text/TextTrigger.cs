using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour {

    public string Text;
    

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<ScrollingText2>() && Input.GetButtonDown("Interact"))
        {
            collision.gameObject.GetComponent<Movement>().LockMovement = true;
            collision.gameObject.GetComponent<MovementAnimation>().LockMovement = true;
            collision.gameObject.GetComponent<ScrollingText2>().SentText = Text;
            collision.gameObject.GetComponent<ScrollingText2>().Writing = true;
            collision.gameObject.GetComponent<ScrollingText2>().CurrentCharacter = 0;
        }

        
    }
}
