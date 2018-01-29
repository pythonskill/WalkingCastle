using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallistScript : MonoBehaviour {

	private bool isUsed;

	// Use this for initialization
	void Start () {
		isUsed = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision)
	{		
		Debug.Log ("Ballist Collised Enter!");
		isUsed = true;
	}

	void OnCollisionExit2D(Collision2D collisionInfo) {
		Debug.Log ("Ballist Collised Exit!");
		isUsed = false;
	}
}
