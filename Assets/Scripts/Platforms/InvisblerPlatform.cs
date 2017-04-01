using UnityEngine;
using System.Collections;
using System;

public class InvisblerPlatform : MonoBehaviour
{
	public float invisTime;
	GameObject player;

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Player") {
			player = collision.gameObject;
			player.GetComponent<SpriteRenderer>().enabled = false;
			Invoke("InvisSpriteReturn", invisTime);
		}
	}
	void InvisSpriteReturn() {
		player.GetComponent<SpriteRenderer>().enabled = true;
	}
}
