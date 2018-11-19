using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    GameObject Player;

    public Vector2 Modifyer;


    public bool IsVertical;
    public bool IsHorizontal;


	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {
       
        if (IsHorizontal == true & IsVertical == true)
        {

            GetComponent<Transform>().transform.position = new Vector3(Player.GetComponent<Transform>().transform.position.x + Modifyer.x, Player.GetComponent<Transform>().transform.position.y + Modifyer.y, GetComponent<Transform>().transform.position.z);
        }
        else if (IsVertical == true)
        {

            GetComponent<Transform>().transform.position = new Vector3(GetComponent<Transform>().transform.position.x, Player.GetComponent<Transform>().transform.position.y + Modifyer.y, GetComponent<Transform>().transform.position.z);

        }
        else if (IsHorizontal == true)
        {

            GetComponent<Transform>().transform.position = new Vector3(Player.GetComponent<Transform>().transform.position.x + Modifyer.x, GetComponent<Transform>().transform.position.y, GetComponent<Transform>().transform.position.z);

        }

    }
}
