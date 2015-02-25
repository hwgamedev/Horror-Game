using UnityEngine;
using System.Collections;

public class WallClosingIn : MonoBehaviour {
	
	public float speed = 1;
	public float moveDistance = 3;
	Vector3 initialPos;
	public Vector3 direction = Vector3.left;
	// Use this for initialization
	void Start () {
		Physics.IgnoreLayerCollision (15, 15);
		initialPos = rigidbody.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(!(Vector3.Distance(initialPos, rigidbody.position) >= moveDistance))
			rigidbody.velocity = direction * speed;
		else
			rigidbody.velocity = new Vector3(0,0,0);

	}
}
