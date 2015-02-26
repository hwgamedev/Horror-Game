using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public float openSpeed = 0.5f;

	private bool moving = false;
	public int closed = 1;

	private Transform target;
	private float str = 500f;
	private float amountRotated = -60f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (moving) {
			transform.Rotate (new Vector3(0,0,openSpeed*closed));
			amountRotated += openSpeed*closed;
			if(Mathf.Abs(amountRotated) > 60) {
				amountRotated = 60*closed;
				moving = false;
				closed *= -1;
			}
			//Quaternion rot = transform.rotation;
			//rot.y += Mathf.Deg2Rad*0.5f*Time.deltaTime;
			//transform.rotation = rot;
		}
	}

	public void moveDoor(Transform t) {
		if (!moving) {
			moving = true;
			target = t;

		}
	}
}
