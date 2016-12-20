/*
This script is created by Burak. Additions made by Ahmet are stated as comments.
*/
using UnityEngine;
using UnityEngine.UI; //To use UI objects like slider and images etc.
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public Score scoreObject;
	public GameObject Car;
	public static bool isHitted;
	//Added to use in PlayerHealth Script by Ahmet(12.18.16 / 4.26 AM)
	//public int score = 0; 
	//Added to use in GameOver and LevelUp Screens by Ahmet(12.18.16/5.47 PM)
	Text text;
	public bool isInside;


	void Start () {
		
		transform.parent = Car.transform;    //Makes player a child of the car for them to move together.
	}

	void OnTriggerEnter(Collider other){
		//Added to use in PlayerHealth Script by Ahmet(12.18.16 / 4.26 AM)
		isHitted = true;
		Debug.Log ("Check for Health");

		//Created a second collider tagged as score. 
		if (other.tag == "score") {
			scoreObject.score += 10;
			isInside = false;
			Debug.Log ("Score" + scoreObject.score);
		}	
	}
		
	void OnTriggerExit(Collider other){
		//Added to use in PlayerHealth Script by Ahmet(12.18.16 / 4.26 AM)
		isHitted = false;
		//score = score + 10; //Added by Ahmet
		Debug.Log ("Check for Health");
	}

	void Update () {
		/*
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.localPosition = new Vector3 (-0.8f, -0.37f, -0.34f);    //Player moves his head to left if left arrow is pressed.
		}

		if(Input.GetKeyUp(KeyCode.LeftArrow)){
			transform.parent = Car.transform;
			transform.localPosition = new Vector3 (-0.53f, -0.37f, -0.34f);    //Player moves back to the right

		}*/
	}

	void FixedUpdate(){
		
		if(Input.GetKey(KeyCode.LeftArrow)){
			isInside = true;
			transform.localPosition = new Vector3 (-0.8f, -0.37f, -0.34f);	//Player moves his head to left if left arrow is pressed.
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			isInside = false;
			transform.parent = Car.transform;
			transform.localPosition = new Vector3 (-0.53f, -0.37f, -0.34f);	//Player moves back to the right

		}
	}

}

