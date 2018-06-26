using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour {
	Door myDoor;

	// Use this for initialization
	void Start () {
		GameObject g = GameObject.FindGameObjectWithTag ("ManualDoor");
		myDoor = g.GetComponent<Door> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            myDoor.openNow = true;
        }
	}
}
