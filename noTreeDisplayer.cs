using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class noTreeDisplayer : MonoBehaviour {

	public Text noTreeText;
	float distanceLeft;

	void Start () {

		distanceLeft = 501;
		noTreeText = GetComponent<Text> ();

	}
	

	void FixedUpdate () {

		if (CarScript.isProtected == true) {

			distanceLeft -= 1;
			
			noTreeText.text = "No trees for " + distanceLeft + " meters";

		}

		if (CarScript.isProtected == false && distanceLeft == 0) {

			Destroy (noTreeText.gameObject);
			distanceLeft = 500;
			Debug.Log (distanceLeft);

		}
	}
}
