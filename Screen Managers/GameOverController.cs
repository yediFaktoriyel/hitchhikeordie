// This script of the project is implemented by Ahmet Ozan Sivri. 
//The script simply manages the start scene. 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Collections;

public class GameOverController : MonoBehaviour {

	//Initalization for buttons
	public Button mainMenu;
	public Button exitGame;

	//Initalization for mini animation


	//Initializations for input name and submit portions




	// Use this for initialization
	void Start () 
	{
		//anim.Play ("gameOverCanvas");
		Button btn = mainMenu.GetComponent<Button> ();
		btn.onClick.AddListener (ChangeScene);
		Button btnE = exitGame.GetComponent<Button> ();
		btnE.onClick.AddListener (ExitGame);

	}

	void Update()
	{
		
	}
		
	void SetandDisplayHighScore()
	{
		
	}



	public void ChangeScene()
	{
		
		SceneManager.LoadScene("startScreen"); //Loads the start screen 


	}

	public void ExitGame()
	{
		Application.Quit();
	}


}
