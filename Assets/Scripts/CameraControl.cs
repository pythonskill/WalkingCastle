using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

	private float scrollSize = 350f;
	private Vector3 cameraPosition;
	public float cameraMoveSpeed = 20f;
	private float screenOffset = 15f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		mouseZoom();
		moseEdgeScreenMove();
	}

	public void moseEdgeScreenMove()
	{
		cameraPosition = transform.position;
		
		if (Input.mousePosition.x >= Screen.width - screenOffset)
		{
			cameraPosition.x += cameraMoveSpeed * Time.deltaTime;
		}

		if (Input.mousePosition.y > Screen.height - screenOffset)
		{
			cameraPosition.y += cameraMoveSpeed * Time.deltaTime;
		}

		if (Input.mousePosition.x < screenOffset)
		{
			cameraPosition.x -= cameraMoveSpeed * Time.deltaTime;
		}

		if (Input.mousePosition.y <= screenOffset)
		{
			cameraPosition.y -= cameraMoveSpeed * Time.deltaTime;
		}

		transform.position = cameraPosition;
	}

	public void mouseZoom()
	{
		if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			if(scrollSize > 105)
				scrollSize = scrollSize - 10;
		}

		if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			if(scrollSize<750)
				scrollSize = scrollSize + 10;
		}

		GetComponent<Camera>().orthographicSize = scrollSize;
	}
}
