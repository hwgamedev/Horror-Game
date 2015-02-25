using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {

	public float minFlickerSpeed = 0.1f; 
	public float maxFlickeringSpeed = 1;
	float initialTime;
	public bool lightEnabled = true;
	float waitTime;
	private Light light1;

	void Start () {
		light1 = GetComponent<Light> ().light;
		initialTime = Time.time;
		waitTime = Random.Range (minFlickerSpeed, maxFlickeringSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		if ((Time.time - initialTime) >= waitTime) {
			Flicker ();
			initialTime = Time.time;
			waitTime = Random.Range (minFlickerSpeed, maxFlickeringSpeed);
		}
	}

	void Flicker()
	{
		//light1.intensity = Random.Range (0,1.1f);
		light1.enabled = !lightEnabled;
		lightEnabled = !lightEnabled;
	}
}
