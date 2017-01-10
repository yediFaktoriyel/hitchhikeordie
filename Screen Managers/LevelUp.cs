// This script of the project is implemented by Ahmet Ozan Sivri and Burak Akkanat. 
//The script simply manages the level up scene. 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Collections;

public class LevelUp : MonoBehaviour {


	public Button mainButton;


	// Use this for initialization
	void Start () {
		Button btn = mainButton.GetComponent<Button> ();
		btn.onClick.AddListener (ChangeScene);

	}

	public void ChangeScene()
	{
		SceneManager.LoadScene("startScreen"); //Loads the first level 
	}






}
