/* This script is created by Burak as a whole. */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreDisplayer : MonoBehaviour {

	CarScript getScriptRef;

	public Text scoreText;

	public int Score;

	//public static int currentScore;

	//public int highScore;

	//public Text highScoreText;



	void Start () {

		scoreText = GetComponent<Text> ();






	}

	void Update () {

		Score = CarScript.Score;
		scoreText.text = "Score: " + Score;
	


	}
}
