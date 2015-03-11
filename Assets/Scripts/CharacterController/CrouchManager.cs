using UnityEngine;
using System.Collections;

public class CrouchManager : MonoBehaviour {

	Vector3 standing_pos;
	Vector3 crouch_pos;
	bool isCrouching; 

	float crouch_height= 0.5f;

	void Awake(){

		standing_pos = transform.localPosition;
		isCrouching = false;

	}

	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown(KeyCode.C)) {
			print ("input c");
			if(isCrouching== false){
				print("crouching initiated");
				transform.localScale = new Vector3 (1, crouch_height, 1);
				isCrouching = true;
			}
			else if(isCrouching==true){
				Vector3 update_pos;
				update_pos = transform.localPosition;
				update_pos.y = standing_pos.y;
				transform.localPosition= update_pos;
				transform.localScale = new Vector3 (1, 1, 1);

				isCrouching=false;
		} 
	}
}

}		

	
	


