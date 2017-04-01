using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlatform : MonoBehaviour
{

    public GameObject exit;
    CollisionControl collisionControl;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.transform.position = exit.transform.position;
            Debug.Log(collision.transform.position);
            //collision.GetComponent<CollisionControl>().OnCollisionEnter2D(null); //Странный костыль
        }
    }
}
    