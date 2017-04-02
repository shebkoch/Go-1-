using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class IcePlatform : MonoBehaviour, IDragHandler, IBeginDragHandler
{
	public Transform platform;
	public Vector3 rotateSpeed;
	Quaternion startRotation;
	public void Start() {
		startRotation = transform.rotation;
	}
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
		platform.rotation = startRotation;
	}
}
