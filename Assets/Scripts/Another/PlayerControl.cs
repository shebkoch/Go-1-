using System.Collections;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.tag == "Border") {
			GameControl.Instance.PlayerDies();
		}
	}
	public void Invinsible(float duration) {
		gameObject.tag = "Invinsible";
		StartCoroutine(InvinsibleTImer(duration));
	}
	IEnumerator InvinsibleTImer(float duration) {
		yield return new WaitForSeconds(duration);
		gameObject.tag = "Player";
	}

}
