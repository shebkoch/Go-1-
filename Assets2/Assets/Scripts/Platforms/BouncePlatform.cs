using UnityEngine;

public class BouncePlatform : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.transform.tag == "Player") {
			PoolController.Instance.activeLevelCount = 2;
		}
	}
}
