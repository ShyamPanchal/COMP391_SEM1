using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	//used when performing physics calculations
	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");//returns value between -1 and 1
		float moveVertival = Input.GetAxis ("Vertical");//returns value between -1 and 1
		/*if (!(moveVertival == 0 && moveHorizontal == 0)) {
			Debug.Log ("H = " + moveHorizontal + " V = " + moveVertival);
		}*/
		Vector2 movement = new Vector2 (moveHorizontal, moveVertival);
		Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D> ();//establishes a connection to the rigid body 2d component
		rb.velocity = movement * speed;
	}
}
