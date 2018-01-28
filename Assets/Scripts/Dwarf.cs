using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwarf : MonoBehaviour {


	public Vector2 direction2;

	public Vector2 moveToPosition2;
	public RaycastHit2D hit2;
	public bool isMoved2;
	[SerializeField]
	protected float speed;
	public Rigidbody2D rb2;


	// Use this for initialization
	void Start () {
		isMoved2 = false;
		speed = 15;

	}

	// Update is called once per frame
	void Update () {

		GetInput ();

	}

	public void SelectObject(){		

		hit2 = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero, Mathf.Infinity);

		if (hit2.collider != null) {			
			rb2 = hit2.rigidbody;
		} 
	}

	public void GetInput(){

		direction2 = Vector2.zero;

		if (Input.GetMouseButtonDown (0)) {
			SelectObject ();
		}

		if(Input.GetMouseButton(1)){
			moveToPosition2 = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			isMoved2 = true;
		}

		if (rb2.position == moveToPosition2) {
			isMoved2 = false;
		}

		if (isMoved2) {	
			rb2.MovePosition (moveToPosition2);
		}

	}


}
