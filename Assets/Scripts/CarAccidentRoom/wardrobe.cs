using UnityEngine;
using System.Collections;

public class wardrobe : MonoBehaviour {

	public Rigidbody doorL;
	public Rigidbody doorR;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		doorL.transform.Rotate(0,30,0);
	}


}
