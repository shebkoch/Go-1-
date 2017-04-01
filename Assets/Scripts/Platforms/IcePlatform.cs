using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class IcePlatform : MonoBehaviour, IDragHandler, IBeginDragHandler
{
	public Transform platform;
	public Vector3 rotateSpeed;
	public void OnBeginDrag(PointerEventData eventData)
	{
		if (Mathf.Abs(eventData.delta.y) > Mathf.Abs(eventData.delta.x))
		{
			StartCoroutine(PlatformRotate(180));
		}
	}
	public IEnumerator PlatformRotate(float angle) {
		while (angle > 0) {
			platform.Rotate(rotateSpeed);
			angle -= rotateSpeed.z;
			yield return new WaitForEndOfFrame();
		}
	}
	public void OnDrag(PointerEventData eventData) { }

	void OnEnable()
	{
		platform.Rotate(new Vector3(0, 0, 180));
	}
}
