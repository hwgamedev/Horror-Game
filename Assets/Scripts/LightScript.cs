using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {

	public float minDisableSpeed = 0.1f; 
	public float maxDisableSpeed = 5;
	float initialTime;
	public bool lightEnabled = true;
	public float intensity;
	public float intensityVariation = 0.3f;
	float waitTime;

	public bool goesBlack = false;

	private Light light1;

	void Start () {
		light1 = GetComponent<Light> ().light;
		initialTime = Time.time;
		waitTime = Random.Range (minDisableSpeed, maxDisableSpeed);
		intensity = light1.intensity;
	}
	
	// Update is called once per frame
	void Update () {
		if (((Time.time - initialTime) >= waitTime) && goesBlack) {
			EnDisable ();
			initialTime = Time.time;
			if(lightEnabled)
				waitTime = Random.Range (minDisableSpeed, maxDisableSpeed);
			else
				waitTime = minDisableSpeed;
		}
	}

	void FixedUpdate()
	{
		Flicker();
	}

	void EnDisable()
	{
		//light1.intensity = Random.Range (0,1.1f);
		light1.enabled = !lightEnabled;
		lightEnabled = !lightEnabled;
	}

	void Flicker()
	{
		light1.intensity = Random.Range(intensity - intensityVariation, intensity + intensityVariation);
	}
}
