// This script of the project is implemented by Ahmet Ozan Sivri. 
//The script simply manages the start scene. 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Collections;

public class GameOver : MonoBehaviour {


	public Button mainMenu;
	public Button exitGame;

	// Use this for initialization
	void Start () {
			
		mainMenu.onClick.AddListener (ChangeScene);

		exitGame.onClick.AddListener (ExitGame);

	}

	public void ChangeScene()
	{
		SceneManager.LoadScene("startMenu"); //Loads the first level 
	}

	public void ExitGame()
	{
		Application.Quit();
	}





}
