/* This script is created by Burak as a whole. */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistanceDisplayer : MonoBehaviour {

	public Text distanceTravelled;
	public float Distance2;


	void Start () {

		distanceTravelled = GetComponent<Text> ();
	
	}
	

	void FixedUpdate () {

		Distance2 = CarScript.Distance;
		distanceTravelled.text = "Distance: " + Distance2;

	}
}
