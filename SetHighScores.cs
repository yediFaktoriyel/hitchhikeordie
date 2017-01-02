using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using LitJson; //The Framework for writing to JSON object.
using System.IO;//For file input output


public class SetHighScores : MonoBehaviour {
		public static int fstHighScore = 0;
		public static int sndHighScore = 0;
		public static int trdHighScore = 0;

	//Initializating the variables which gonna be used in reading the JSON file
	private string jsonString;
	private JsonData itemData;

	void Start()
	{
		jsonString = File.ReadAllText(Application.dataPath +"/highestPlays.json");
		itemData = JsonMapper.ToObject (jsonString);
		Debug.Log (itemData ["Name"]);

	}


}


