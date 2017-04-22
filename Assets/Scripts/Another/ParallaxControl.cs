using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxControl : MonoBehaviour
{

	[Tooltip("Направление движения(вправо -1,0,0)")]
	public Vector3 vect; 
	public float speed;
	[Tooltip("Объект за которым будет появляться этот")]
	public GameObject prevObj;
	[Tooltip("Расстояние между центрами этого и prev объектов")]
	public Vector3 distance;

	void Update() {
		transform.Translate(vect * speed * Time.deltaTime);
	}
	void OnBecameInvisible() {
		transform.position = prevObj.transform.position + distance;
	}
}
