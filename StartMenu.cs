// This portion of the project is implemented by Ahmet Ozan Sivri. 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartMenu : MonoBehaviour {

	public Canvas exitGame;
	public Button startText;
	public Button exitText;

	// Use this for initialization
	void Start () {
		exitGame = exitGame.GetComponent<Canvas> ();
		exitGame.enabled = false;
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
	}

	public void Exit()
	{
		exitGame.enabled = true;
		startText.enabled = false;
		exitText.enabled = false; 
	}

	public void noExit()
	{
		exitGame.enabled = false;
		startText.enabled = true;
		exitText.enabled = true; 
	}

	public void startGame()
	{
		SceneManager.LoadScene("hhod"); 
	}

	public void ExitGame()
	{
		Application.Quit();
	}


	// Update is called once per frame
	void Update () {
	
	}
}
