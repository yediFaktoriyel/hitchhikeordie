// This script of the project is implemented by Ahmet Ozan Sivri. 
//The script is a tool to show an object on the next scenes. For instance, we want to keep score for game over scene.
using UnityEngine;
using System.Collections;

public class dontDestroyOnNext : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	

}
