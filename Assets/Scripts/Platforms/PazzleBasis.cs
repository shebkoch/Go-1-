using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PazzleBasis : MonoBehaviour {

    public GameObject leftObj;
    public GameObject rightObj;
    Vector2 leftObjPos;
    Vector2 rightObjPos;
    public Sprite empty;
    public Sprite left;
    public Sprite right;
    public Sprite full;
    public bool isLeftFill;
    public bool isRightFill;
    SpriteRenderer spriteRenderer;
    void OnEnable()
    {
        leftObj.SetActive(true);
        leftObj.SetActive(true);
    }
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        PazzlePlatform pazzlePlatform = collision.GetComponent<PazzlePlatform>();
        if (pazzlePlatform != null)
        {
            if (pazzlePlatform.isLeft)
                isLeftFill = true;
            else
                isRightFill = true;
            if (isLeftFill && isRightFill)
            {
                tag = "Platform";
                spriteRenderer.sprite = full;
            }
            else if (isLeftFill) spriteRenderer.sprite = left;
            else if (isRightFill) spriteRenderer.sprite = right;
            collision.gameObject.SetActive(false);
        }
    }

}
