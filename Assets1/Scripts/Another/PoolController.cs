using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PoolController : MonoBehaviour
{
	public static PoolController Instance { get; private set; }
	[System.Serializable]
	public class Platform
	{
		public GameObject platform;
		public float probability;
	}
	public List<Platform> platforms;
	public GameObject player;
	public float startAngle;
	public float startVelocity;
	Vector2 playerVelocity;
	Vector2 platformVelocity;
	public List<Vector2> startPositions;
	float maxRand = 0;
	public int activeLevelCount = 1;
	Rigidbody2D playerRigidbody;

	public void Awake() {
		Instance = this;
		playerRigidbody = player.GetComponent<Rigidbody2D>();
	}
	private void Start() {

		startAngle *= 0.0174533f;													//Перевод в радианы
		platformVelocity = new Vector2(
								-startVelocity * Mathf.Cos(startAngle),
								0);
		playerVelocity = new Vector2(
								0,
								startVelocity * Mathf.Sin(startAngle));

		foreach (Platform platform in platforms) {
			PlatformPool.Instance.Push(platform.platform);
			maxRand += platform.probability;
		}
		foreach(var position in startPositions)
			PlatformPool.Instance.Pop(position, 0);
	}

	int RandomSelect() {
		float probablyRand = maxRand;
		float curRand = Random.Range(0, maxRand);
		int curPlatfrom = 0;
		for (int i = 0; i < platforms.Count; i++) {
			probablyRand -= platforms[i].probability;
			if (probablyRand <= curRand)
				return i;
		}
		return curPlatfrom;
	}
	public void PlatformControl() {
		float spawnPosX = startPositions[startPositions.Count - 1].x + 2.5f;
		for (int i = 0; i < activeLevelCount; i++) {
			PlatformPool.Instance.Pop(new Vector2(spawnPosX, i - 1), RandomSelect());
			PlatformPool.Instance.RigidbodyControl(platformVelocity);
			playerRigidbody.velocity = playerVelocity;
		}
	}
}