using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWarp : MonoBehaviour {

    public GameObject PlayerPointer;
    public GameObject CameraPointer;

    public GameObject Player;
    GameObject Camera;
  
    bool Check;

    GameObject Fade;

	// Use this for initialization
	void Start () {
        Fade = GameObject.FindGameObjectWithTag("Fade");

       // Player = GameObject.FindGameObjectWithTag("Player");
        Camera = GameObject.FindGameObjectWithTag("MainCamera");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Fade.GetComponent<Fade>().FadeIn = true;
        Check = true;
        Camera.GetComponent<FollowPlayer>().IsHorizontal = false;
        Camera.GetComponent<FollowPlayer>().IsVertical = false;
    }

    private void Update()
    {
        if (Fade.GetComponent<Fade>().FadeIn == false && Check == true)
        {
            Player.GetComponent<Transform>().position = PlayerPointer.GetComponent<Transform>().position;
            Camera.GetComponent<Transform>().position = new Vector3(CameraPointer.GetComponent<Transform>().position.x, CameraPointer.GetComponent<Transform>().position.y, -10);

            Fade.GetComponent<Fade>().FadeOut = true;
            Check = false;

        }
    }


}
