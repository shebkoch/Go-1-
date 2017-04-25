using UnityEngine;
using UnityEngine.EventSystems;
public class StartButton : MonoBehaviour, IPointerClickHandler
{
	public void OnPointerClick(PointerEventData eventData) {
		Time.timeScale = 1;
		gameObject.SetActive(false);
	}
}
