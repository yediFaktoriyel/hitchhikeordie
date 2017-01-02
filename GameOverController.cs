
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using LitJson; //The Framework for writing to JSON object.
using System.IO;//For file input output



public class GameOverController : MonoBehaviour {

	//Initialization portion to get Score
	CarScript getScriptRef;

	//Getting highest three scores 
	SetHighScores getScoreRef1;
	SetHighScores getScoreRef2;
	SetHighScores getScoreRef3;

	//public Text scoreText;
	public int Score;
	//Initializating local highest scores.
	public int first;
	public int second;
	public int third;



	//Initialization for input portion
	public InputField inputName;
	InputField.SubmitEvent se;
	public Text submittedName;


	//Creating Dumb datas to check if it's running
	/*
	public HighScoreTable dumb1 = new HighScoreTable("Ahmet", 1000);
	public HighScoreTable dumb2 = new HighScoreTable("Burak", 3000);
	public HighScoreTable dumb3 = new HighScoreTable("Dogu", 500);
	*/




	//A JSON object
	static JsonData realData;

	// Use this for initialization
	void Start () {
		//scoreText = GetComponent<Text> ();

	}	
	
	// Update is called once per frame
	void Update () {
		//Show the score on the screen.
		Score = CarScript.Score;
		first = SetHighScores.fstHighScore;
		second = SetHighScores.sndHighScore;
		third = SetHighScores.trdHighScore;
		//scoreText.text = "Your Score" +Score;

	}

	public void getByButton()
	{
		submittedName.text = inputName.text;
		WriteToJSON ();

	}

	void WriteToJSON()
	{
		HighScoreTable HighScoreByGame ;
		HighScoreTable SecondHighScore ;
		HighScoreTable ThirdHighScore ;
		if (Score > first) {
			HighScoreByGame = new HighScoreTable (submittedName.text, Score);
			realData = JsonMapper.ToJson (HighScoreByGame);
		} 
		else if (Score < first && Score > second)
		{
			SecondHighScore = new HighScoreTable (submittedName.text, Score);
			realData = JsonMapper.ToJson (SecondHighScore);
		}
		else if (Score < first && Score < second && Score > third)
		{
			ThirdHighScore = new HighScoreTable (submittedName.text, Score);
			realData = JsonMapper.ToJson (ThirdHighScore);
		}


		//HighScoreTable HighScoreByGame = new HighScoreTable(submittedName.text, Score);
		Debug.Log (submittedName.text);
		//Convert the normal data to JSON data

		//Pushing the dumb datas
		//realData = JsonMapper.ToJson (dumb1);
		//realData = JsonMapper.ToJson (dumb2);
		//realData = JsonMapper.ToJson (dumb3);
		//Configure and write the data.
		File.WriteAllText (Application.dataPath + "/highestPlays.json", realData.ToString ());
	}
}


//Arrange the class and variables in HighScore class.
public class HighScoreTable{
	public int highScore;
	public string name;

	public HighScoreTable(string name, int highScore)
	{
		this.name = name;
		this.highScore = highScore;
	}

}


