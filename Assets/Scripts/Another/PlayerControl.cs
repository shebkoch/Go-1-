using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.tag == "Border")
			GameControl.Instance.PlayerDies();
	}

}
