using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
		RaycastHit hitObject;
		if (Physics.Raycast (transform.position, fwd, out hitObject, 10f)) {
			print ("Scenery in sight!");
			if(Input.GetKey("e")) {
				if(hitObject.collider.CompareTag("Item")) {
					//TODO: put item in inventory
					Destroy (hitObject.collider.gameObject);
				}
				else if(hitObject.collider.CompareTag("Scenery")) {
					Scenery sc = hitObject.collider.GetComponent<Scenery>();
					if(!sc.isAttached())
						sc.attachTo(transform.Find("Main Camera"));
				}
				else if(hitObject.collider.CompareTag("Door")) {
					hitObject.collider.GetComponent<Door>().moveDoor(transform);
				}
			}
			else
				print ("Unknown item");
		}
	}
}
