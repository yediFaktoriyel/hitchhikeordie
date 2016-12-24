using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreDisplayer : MonoBehaviour {

	CarScript getScriptRef;

	public Text scoreText;
	public int Score;


	void Start () {

		scoreText = GetComponent<Text> ();

	}

/*	void OnGUI() {

		GUI.Label (Rect(0,0,100,100), scoreText.text);

	}
*/



	void Update () {

		Score = CarScript.Score;
		scoreText.text = "Score: " + Score;

	}


}
