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
		if (Physics.Raycast (transform.position, fwd, out hitObject, 1)) {
			if(Input.GetKey("e") && hitObject.collider.CompareTag("Item")) {
				//TODO: put item in inventory
				Destroy (hitObject.collider.gameObject);
			}
			else
				print ("Unknown item");
		}
	}
}
