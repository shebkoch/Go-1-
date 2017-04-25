using UnityEngine;

public class SleepControl : MonoBehaviour
{

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.transform.tag == "Border")
			gameObject.SetActive(false);
	}

}