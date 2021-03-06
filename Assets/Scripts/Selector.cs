﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour {


	public RaycastHit2D hit;
	public GameObject unitObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetInput ();
	}

	// выбор объекта
	public void SelectObject(){		

		hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero, Mathf.Infinity);

		if (hit.collider != null) {			
			unitObject = hit.transform.gameObject;
		} else {
			// сбрасываем выбранный	 объект
			unitObject = null;
		}
	}

	// прослушивание клавиатуры и мыши
	public void GetInput(){
		if (Input.GetMouseButtonDown (0)) {
			SelectObject ();
		}

		if(Input.GetMouseButton(1)){
			Character characterScript = (Character) unitObject.GetComponent(typeof(Character));
			characterScript.SetMoveToPosition(Camera.main.ScreenToWorldPoint (Input.mousePosition));
			characterScript.SetAllowMove(true);
		}
	}
}
