using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameControl : MonoBehaviour
{
	public static GameControl Instance { get; private set; }
	public float timeScaleIncValue;
	public float timeBetweenInc;
	public GameObject startButton;
	bool isEnd;
	public void Awake() {
		Instance = this;
		StartCoroutine(TimeScaleInc());
		//Time.timeScale = 0.0001f;
	}

	IEnumerator TimeScaleInc() {
		while (true) {
			if (100 - Time.timeScale < 1) break;
			Time.timeScale += timeScaleIncValue;
			yield return new WaitForSeconds(timeBetweenInc);
		}
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit();
		}
		if (Input.GetKeyDown(KeyCode.R) || (isEnd && Input.touchCount > 0)) {
			Time.timeScale = 1;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
	public void PlayerDies() {
		ScoreControl.Instance.EndGame();
		StartButton.Instance.EndGame();
		isEnd = true;


	}
	public IEnumerator InvisSpriteReturn(Collider2D player, float invisTime) {
		yield return new WaitForSeconds(invisTime);
		player.gameObject.GetComponent<SpriteRenderer>().enabled = true;
	}
}
