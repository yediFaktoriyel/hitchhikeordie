// This script of the project is implemented by Ahmet Ozan Sivri. 
//The script simply manages the start scene. 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Collections;

public class RightUpController : MonoBehaviour {


	public Button stopGame;
	public Button exitGame;

	// Use this for initialization
	void Start () {
		




	}

	void Update()
	{
		Button btn = stopGame.GetComponent<Button> ();
		btn.onClick.AddListener (StopGame);

		if(Input.GetKey(KeyCode.P))
		{
			StopGame ();
		}

		Button btnE = exitGame.GetComponent<Button> ();
		btnE.onClick.AddListener (ExitGame);

		if(Input.GetKey(KeyCode.Escape))
		{
			ExitGame ();
		}
	}

	public void StopGame()
	{
		Time.timeScale = 0; //Stops the game.
	}

	public void ResumeGame()
	{
		Time.timeScale = 1; //Re run the game
	}

	public void ExitGame()
	{
		Application.Quit();
	}


}
