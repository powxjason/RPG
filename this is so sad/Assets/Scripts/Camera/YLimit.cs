using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YLimit : MonoBehaviour {

    GameObject Player;
    GameObject Camera;
    
    // Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Camera.GetComponent<FollowPlayer>().IsVertical = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Camera.GetComponent<FollowPlayer>().IsVertical = false;
    }
}
