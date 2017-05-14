using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeCollision : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            //collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-80f, 200f));
            collision.gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
			//Debug.Log("drfr");
			GameControl.Instance.PlayerDies();
			//gameControl.playerDies();
        }
    }
}
