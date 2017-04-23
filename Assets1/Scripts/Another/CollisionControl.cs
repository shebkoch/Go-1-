using UnityEngine;
using System.Collections;

public class CollisionControl : MonoBehaviour
{

	public void OnTriggerEnter2D(Collider2D collision) {
		if (collision.tag == "Platform")
			PoolController.Instance.PlatformControl();
	}
}
