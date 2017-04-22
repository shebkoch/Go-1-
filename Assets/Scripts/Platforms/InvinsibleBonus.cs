using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class InvinsibleBonus : MonoBehaviour, IPointerClickHandler
{
	GameObject player;
	public float duration;
	public Vector2 force;
	public float amplitudeTime;
	public Rigidbody2D t_rigidbody;
	private void Awake() {
		player = GameObject.FindWithTag("Player");
	}
	public void OnPointerClick(PointerEventData eventData) {
		player.GetComponent<PlayerControl>().Invinsible(duration);
	}

	
}
