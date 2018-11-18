using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    GameObject Player;
    Vector2 playerLocation;

    public bool IsVertical;
    public bool IsHorizontal;


	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {
        playerLocation = new Vector3(Player.GetComponent<Transform>().transform.position.x, Player.GetComponent<Transform>().transform.position.y, GetComponent<Transform>().transform.position.z);

        if (IsHorizontal == true & IsVertical == true)
        {

            GetComponent<Transform>().transform.position = playerLocation;

        }
        else if (IsVertical == true)
        {

            GetComponent<Transform>().transform.position = new Vector3(GetComponent<Transform>().transform.position.x, Player.GetComponent<Transform>().transform.position.y, GetComponent<Transform>().transform.position.z);

        }
        else if (IsHorizontal == true)
        {

            GetComponent<Transform>().transform.position = new Vector3(Player.GetComponent<Transform>().transform.position.x, GetComponent<Transform>().transform.position.y, GetComponent<Transform>().transform.position.z);

        }

    }
}
