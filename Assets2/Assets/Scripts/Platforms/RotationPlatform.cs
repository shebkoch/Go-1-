using UnityEngine;
using System.Collections;

public class RotationPlatform : MonoBehaviour {
    public float rotateSpeed;
	// Use this for initialization
	void Awake () {
        transform.Rotate(0, 0, Random.Range(0, 50));
	}   
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(new Vector3(0,0,rotateSpeed));
        }
    }
}
