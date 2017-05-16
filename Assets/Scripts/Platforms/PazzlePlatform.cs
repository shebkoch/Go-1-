using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PazzlePlatform : MonoBehaviour, IDragHandler
{
    public bool isLeft;
    public void OnDrag(PointerEventData eventData)
    {
        Plane plane = new Plane(Vector3.forward, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(eventData.position);
        float distance;
        if (plane.Raycast(ray, out distance))
        {
            transform.position = ray.origin + ray.direction * distance;
        }
    }
}
