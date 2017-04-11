using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour, IPointerClickHandler
{
	public static StartButton Instance { get; private set; }
	public float startTimeScale = 1;
	bool isEnd = false;
	public void Awake() {
		Instance = this;
		gameObject.SetActive(false);
	}
	public void OnPointerClick(PointerEventData eventData) {
		Time.timeScale = startTimeScale;
		gameObject.SetActive(false);
		if (isEnd) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void EndGame() {
		isEnd = true;
		gameObject.SetActive(true);
		Time.timeScale = 0.00001f;
	}
}
