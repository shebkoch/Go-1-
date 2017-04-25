using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsPlatform : MonoBehaviour {

	public Rigidbody2D[] walls; 
	public Vector2[] wallsForces;
	void OnTriggerEnter2D(Collider2D collision) {
		if(collision.transform.tag == "Player") {
			walls[0].AddForce(wallsForces[0]);
			walls[1].AddForce(wallsForces[1]);
		}
	}
}
