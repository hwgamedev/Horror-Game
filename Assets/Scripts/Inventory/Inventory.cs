using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
	public GameObject slots;
	public List<GameObject> slotList = new List<GameObject> ();
	public List<Item> items = new List<Item> ();

	//setup constants
	private int columnsOfItems = 7;
	private int rowsOfItems = 5;
	private int xStart = -180;
	private int yStart = 120;
	private int distanceBetweenItems = 60;
	// Use this for initialization
	void Start ()
	{
		for (int j = 1; j<=rowsOfItems; j++)
			for (int i = 1; i<=columnsOfItems; i++) {
				GameObject slot = (GameObject) Instantiate(slots);
				slot.transform.SetParent(this.gameObject.transform);
				slot.name = "Slot"+j+"."+i;
				slot.GetComponent<RectTransform>().localPosition = new Vector3(xStart + ((i-1) * distanceBetweenItems), yStart - ((j-1) * distanceBetweenItems), 0);
				slot.GetComponent<RectTransform>().localScale = new Vector3(1,1,1);
				slotsList.Add(slot);
			}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

