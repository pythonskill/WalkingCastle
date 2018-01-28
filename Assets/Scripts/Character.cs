using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	// точка, куда перемещается персонаж
	public Vector3 moveToPosition;
	// флаг говорит когда разрешено перемещение
	public bool allowMove;
	// скорость перемещения 
	public float speed = 15f;
	// Текущее местоположение выраженное в Vector2
	public Vector2 direction;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	public void SetMoveToPosition(Vector3 moveToVector){
		moveToPosition = moveToVector;
		moveToPosition.z = transform.position.z;
	}

	public void SetAllowMove(bool moveFlag){
		allowMove = moveFlag;
	}

	public void Move(){
		direction = Vector2.zero;

		if(allowMove){						
			transform.position = Vector3.MoveTowards (transform.position, moveToPosition, speed * Time.deltaTime);
			if(moveToPosition.x < transform.position.x){
				direction += Vector2.left;
			}

			if(moveToPosition.x > transform.position.x){
				direction += Vector2.right;
			}

			if (transform.position == moveToPosition || moveToPosition.x == transform.position.x) {
				allowMove= false;
			}
		}
	}
}
