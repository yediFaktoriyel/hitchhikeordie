/*
This script is created by Burak. Additions made by Ahmet are stated as comments.
*/

using UnityEngine;
using UnityEngine.UI; //To use UI objects like slider and images etc.
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public ScoreDisplayer scoreObject;
	public GameObject Car;
	public static bool isHitted;
	//Added to use in GameOver and LevelUp Screens by Ahmet(12.18.16/5.47 PM)
	Text text;


	void Start () {
		
		transform.parent = Car.transform;    //Makes player a child of the car for them to move together.
	}

	void OnTriggerEnter(Collider other){
		
		isHitted = true;

	}
		
	void OnTriggerExit(Collider other){
		
		isHitted = false;

	}

	void Update () {
		
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			
			transform.localPosition = new Vector3 (-0.8f, -0.297f, -0.34f);		//Player moves his head to left if left arrow is pressed...

		}

		if(Input.GetKeyUp(KeyCode.LeftArrow)){

			transform.parent = Car.transform;
			transform.localPosition = new Vector3 (-0.53f, -0.297f, -0.34f);	//... and player moves back to the right

		}
	}



	void FixedUpdate(){


	}

}

