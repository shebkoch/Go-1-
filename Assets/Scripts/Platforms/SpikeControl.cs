using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SpikeControl : MonoBehaviour, IPointerClickHandler
{
    public float platformRadius;
    public GameObject spikes;
    float maxPos;
    bool isClicked = false;
    public float speed;
    float zPos;
    void Start()
    {
        zPos = transform.position.z;
    } 
    void Update()
    {
        if (isClicked)
        {
            spikes.transform.position = new Vector3(
                spikes.transform.position.x, 
                Mathf.Lerp(spikes.transform.position.y, maxPos, Time.deltaTime*speed),
                zPos);
      
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        isClicked = true;
    }
    void OnEnable()
    {
        maxPos = spikes.transform.position.y - platformRadius;
    }
    void OnDisable()
    {
		if(isClicked) spikes.transform.position += new Vector3(0, platformRadius, zPos);
		isClicked = false;
	}

}
