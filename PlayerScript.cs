/*
This script is created by Burak. Additions made by Ahmet are stated as comments.
*/

using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public GameObject Car;
	public static bool isHitted;
	//Added to use in PlayerHealth Script by Ahmet(12.18.16 / 4.26 AM)
    

	void Start () {
		transform.parent = Car.transform;	//Makes player a child of the car for them to move together.
	}

	void OnTriggerEnter(Collider other){
		//Added to use in PlayerHealth Script by Ahmet(12.18.16 / 4.26 AM)
		isHitted = true;
		Debug.Log ("Check for Health");
	}

	void OnTriggerExit(Collider other){  // ***** BUNU EKLEDiM ****
		//Added to use in PlayerHealth Script by Ahmet(12.18.16 / 4.26 AM)
		isHitted = false;
		Debug.Log ("Check for Health");
	}

		
	void Update () {
		/*
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.localPosition = new Vector3 (-0.8f, -0.37f, -0.34f);	//Player moves his head to left if left arrow is pressed.
		}

		if(Input.GetKeyUp(KeyCode.LeftArrow)){
			transform.parent = Car.transform;
			transform.localPosition = new Vector3 (-0.53f, -0.37f, -0.34f);	//Player moves back to the right

		}*/
			
	}

	void FixedUpdate(){
		
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.localPosition = new Vector3 (-0.8f, -0.37f, -0.34f);	//Player moves his head to left if left arrow is pressed.
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			transform.parent = Car.transform;
			transform.localPosition = new Vector3 (-0.53f, -0.37f, -0.34f);	//Player moves back to the right

		}
	}
}
