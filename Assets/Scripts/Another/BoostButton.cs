using UnityEngine;
using UnityEngine.EventSystems;
public class BoostButton : MonoBehaviour, IPointerClickHandler
{
	public float boostSpeed;
	public void OnPointerClick(PointerEventData eventData) {
		Time.timeScale = boostSpeed;
	}
}
