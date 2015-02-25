using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public float strength = .5f;

	private Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (target != null && Input.GetKey("e")) {
			Quaternion targetRotation = Quaternion.LookRotation (target.position - transform.parent.position);
			float str = Mathf.Min (strength * Time.deltaTime, 1);
			Quaternion rot = transform.parent.rotation;
			rot.y =  Quaternion.Lerp (transform.rotation, targetRotation, str).y;
			transform.parent.rotation = rot;
		}
	}

	public void moveDoor(Transform t) {
		target = t;
	}
}
