using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class GhostyPlatform : MonoBehaviour, IPointerClickHandler
{
    public Sprite activeSprite;
    public Sprite disactiveSprite;
	public GameObject GhostParent;
    public void OnPointerClick(PointerEventData eventData){
        GhostParent.GetComponent<SpriteRenderer>().sprite = activeSprite;
		GhostParent.GetComponent<BoxCollider2D>().enabled = true;
    } 
    void OnDisable()
    {
		GhostParent.GetComponent<SpriteRenderer>().sprite = disactiveSprite;
		GhostParent.GetComponent<BoxCollider2D>().enabled = false;
    }
}
 