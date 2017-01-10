/* This script is created by Burak as a whole. */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScoreDisplayer : MonoBehaviour {



	public Text highScoreText;
	public int highScore = 0;





	void Start () {

		highScoreText = GetComponent<Text> ();

		highScore = PlayerPrefs.GetInt ("highScore", highScore);
		highScoreText.text.ToString ();

	}

	void Update () {

		//currentScore = CarScript.Score;

		//highScoreText.text = "Highest Score: " + ScoreDisplayer.currentScore;

		Debug.Log ("High Score: " + highScore);


		if (CarScript.Score>highScore) 
		{
			highScore = CarScript.Score;
			highScoreText.text = "Highest asdScore: " + highScore;
			PlayerPrefs.SetInt ("highScore", highScore);
		}
		highScoreText.text = "Highest asdScore: " + highScore;

	}
}
