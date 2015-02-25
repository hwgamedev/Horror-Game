using UnityEngine;
using System.Collections;

public class Scenery : MonoBehaviour {

	private Transform attachedTo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (attachedTo != null) {
			transform.position = attachedTo.position + attachedTo.transform.forward * 1.5f;
			transform.LookAt(attachedTo);
		}

		if (Input.GetMouseButtonDown (0)) {
			rigidbody.AddForce (attachedTo.forward*1000f);
			attachedTo = null;
		}
	}

	public void attachTo(Transform t) {
		attachedTo = t;
		print ("Yay");
	}

	public bool isAttached() {
		return attachedTo != null;
	}
}
