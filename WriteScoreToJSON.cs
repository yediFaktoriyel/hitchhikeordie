using UnityEngine;
using System.Collections;
using LitJson; //from the dll that I downloaded
using System.IO;//For file input output

public class WriteScoreToJSON : MonoBehaviour {
	

	public static HighScoreTable HighScorebyGame = new HighScoreTable(CarScript.Score, CarScript.Distance);


	public HighScoreTable HighScore = new HighScoreTable(100, 100);


	double float2DoubleDistance = System.Convert.ToDouble(CarScript.Distance);

	JsonData dumbData;
	static JsonData realData;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
		//Problem: Not updating JSON file.
		//TODO: Fix the problem.
		if (BuraksPlayerHealth.isDead == true) {
			Debug.Log ("In the statement");
			Debug.Log (realData);
			realData = JsonMapper.ToJson (HighScorebyGame);
			File.WriteAllText (Application.dataPath + "/highestPlays.json", realData.ToString());
		}

	}	
}

public class HighScoreTable{
	public  int highScore;
	public  double highDistance; 

	public HighScoreTable(int highScore, double highDistance)
	{
		this.highScore = highScore;
		this.highDistance = highDistance;
	}
}
