// This script of the project is implemented by Ahmet Ozan Sivri. 
//The script simply manages the start scene. 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Collections;

public class StartLevel : MonoBehaviour {


	public Button startLevel;


	// Use this for initialization
	void Start () {
		Button btn = startLevel.GetComponent<Button> ();
		btn.onClick.AddListener (ChangeScene);

	}

	public void ChangeScene()
	{
		SceneManager.LoadScene("hhod"); //Loads the first level 
	}



}