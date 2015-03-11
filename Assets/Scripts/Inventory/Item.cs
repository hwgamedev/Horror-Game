using UnityEngine;
using System.Collections;

public class Item {

	public string itemName;
	public int itemID;
	public string itemDescription;
	public Sprite itemIcon;
	public GameObject itemObject;
	// Use this for initialization

	public Item (string name, int ID, string desc) 
	{
		itemName = name;
		itemID = ID;
		itemDescription = desc;
		itemIcon = Resources.Load<Sprite>(name);

	}

	public Item ()
	{
	}
}
