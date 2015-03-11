using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler {

	public Item item;
	Image itemImage;
	int slotNumber;
	// Use this for initialization
	void Start () {
		itemImage = gameObject.transform.GetChild(0).GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (item != null) {
			itemImage.enabled = true;
			itemImage.sprite = item.itemIcon;
		}
	}

	public void OnPointerDown(PointerEventData data)
	{
		Debug.Log ("click");
	}

	public void OnPointerEnter(PointerEventData data)
	{
		Debug.Log ("enter");
	}
}
