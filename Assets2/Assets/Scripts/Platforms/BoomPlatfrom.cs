using UnityEngine;
using UnityEngine.EventSystems;
public class BoomPlatfrom : MonoBehaviour, IPointerClickHandler
{
	public void OnPointerClick(PointerEventData eventData) {
		transform.parent.gameObject.SetActive(false);
	}

}
