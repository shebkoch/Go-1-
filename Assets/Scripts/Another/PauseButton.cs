using UnityEngine;
using UnityEngine.EventSystems;
public class PauseButton : MonoBehaviour, IPointerClickHandler {

	public GameObject toTapButton;
	public void OnPointerClick(PointerEventData eventData) {
		Time.timeScale = 0.0001f;
		toTapButton.SetActive(true);
	}
}
