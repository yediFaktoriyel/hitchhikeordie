// This script of the project is implemented by Ahmet Ozan Sivri. 
//The script simply manages the pause menu. 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Collections;

public class PauseMenuController : MonoBehaviour {

	//For getting the whole Pause Menu
	public Canvas PauseMenu;

	//Initializing the buttons
	public Button resumeGame;
	public Button exitGame;

	void Start()
	{
		PauseMenu.GetComponent<Canvas> ();
		PauseMenu.enabled = false;


	}

	void Update()
	{
		resumeGame.GetComponent<Button> ();
		resumeGame.onClick.AddListener (DeactiveScreen);

		exitGame.GetComponent<Button> ();
		exitGame.onClick.AddListener (ExitGame);


		if (RightUpController.inFun == true)
		{
			ActiveScreen ();
		}

		else 
		{
			DeactiveScreen ();
		}

		if (RightUpController.isPushed == true)
		{
			ExitGame ();
		}
	}

	public void ActiveScreen()
	{
		PauseMenu.enabled = true;
		Time.timeScale = 0;
	}


	public void DeactiveScreen()
	{
		Time.timeScale = 1;
		PauseMenu.enabled = false;
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}
