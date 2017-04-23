using UnityEngine;
using System.Collections.Generic;
using System.Linq;
public class PlatformPool : MonoBehaviour
{
	public int StartSamePlatforms = 20;
	public static PlatformPool Instance { get; private set; }
	List<List<GameObject>> platforms = new List<List<GameObject>>();
	List<List<Rigidbody2D>> rigidbodyPool = new List<List<Rigidbody2D>>();
	public void Awake() { Instance = this; }

	public void Push(GameObject toPush) {
		platforms.Add(new List<GameObject>());
		for (int i = 0; i < StartSamePlatforms; i++) {
			platforms.Last().Add(Instantiate(toPush) as GameObject);
			platforms.Last()[i].SetActive(false);
		}
		SetRigidbody();
	}
	public void Pop(Vector3 pos, int platformType) {
		bool isAllActive = true;
		foreach (var platform in platforms[platformType]) {
			if (!platform.activeInHierarchy) {
				platform.transform.position = pos;
				platform.SetActive(true);
				isAllActive = false;
				break;
			}
		}
		if (isAllActive) {
			Add(platformType, platforms[platformType][0]);
		}
	}
	public void Add(int platformType, GameObject elem) {
		platforms[platformType].Add(elem);
	}

	public void SetRigidbody() {
		rigidbodyPool.Add(new List<Rigidbody2D>());
		foreach (var samePlatform in platforms) {
			foreach (var platform in samePlatform) {
				rigidbodyPool.Last().Add(platform.GetComponent<Rigidbody2D>());
			}
		}
	}
	public void RigidbodyControl(Vector3 platformVelocity) {
		foreach (var sameRigidbody in rigidbodyPool) {
			foreach (var rigidbody in sameRigidbody)
				rigidbody.velocity = platformVelocity;
		}
	}
}
