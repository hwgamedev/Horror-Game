using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {
	
	
	public float speed = 10.0f;
	public float gravity = 10.0f;
	//public float maxVelocityChange = 10.0f;
	
	// Use this for initialization
	void Awake () {
		
		rigidbody.useGravity = false;
		//rigidbody.freezeRotation = true;
		
	}
	
	void FixedUpdate () {

		if (Input.GetKey (KeyCode.W)) {
			rigidbody.transform.localPosition += (transform.forward * speed * Time.deltaTime);
		}


		if(Input.GetKey(KeyCode.S)){
		   rigidbody.transform.localPosition -= (transform.forward * speed * Time.deltaTime);
		}
		

		if(Input.GetKey(KeyCode.A)){
		   rigidbody.transform.localPosition -= transform.right * speed * Time.deltaTime;
		}
		

		if(Input.GetKey(KeyCode.D)){
		   rigidbody.transform.localPosition+= transform.right * speed * Time.deltaTime;	
		}
				
		//rigidbody.AddForce(new Vector3 (0, -gravity * rigidbody.mass, 0));

	} 
}
