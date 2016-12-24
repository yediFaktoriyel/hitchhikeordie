// This script of the project is implemented by Ahmet Ozan Sivri. 
//The script simply manages the start scene. 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Collections;

//TODO: Fix the GUI on pause screen

public class RightUpController : MonoBehaviour {


	//Buttons on right up
	public Button stopGame;
	public Button exitGame;

	//Buttons on pause menu:
	public Button resumeGame;
	public Button turnMainMenu;
	public Button restartLevel;
	public Button exitGameWhileStop;

	Canvas canvas;


	Animator anim;

	bool isRunning = true;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
		anim.SetBool ("PauseMenu", false);
		//anim ["PauseMenu"].time = animTime; 
		//anim.SetTrigger ("IdleState");
		canvas = GetComponent<Canvas>();
		canvas.enabled = false;

	}

	void Update()
	{
		//Pausing portion
		Button btn = stopGame.GetComponent<Button> ();
		btn.onClick.AddListener (StopGame);

		if(Input.GetKey(KeyCode.P))
		{
			StopGame ();
		}
		if(Input.GetKey(KeyCode.C))
		{
			StopGame ();
		}
		//==============
		//Pause Menu Portion

		resumeGame.onClick.AddListener (ResumeGame);

		turnMainMenu.onClick.AddListener (MainMenu);

		restartLevel.onClick.AddListener (RestartGame);

		exitGameWhileStop.onClick.AddListener (ExitGame);

		//=================
		if(Input.GetKey(KeyCode.Escape))
		{
			ExitGame ();
		}
	}
		
	//AnimationState.time >= AnimationState.normalizedTime
	public void StopGame()
	{
		//Used this method instead of normal Time.timeScale
		//Because the animation wasn't able to play.
		anim.SetTrigger ("PauseMenu");
		anim.Play ("PauseMenu");

		waitForAnimate (10f);
		canvas.enabled = !canvas.enabled;
		Time.timeScale = Time.timeScale == 0 ? 1 : 0; //Stops the game.
	

	}

	IEnumerator waitForAnimate(float seconds)
	{
		yield return new WaitForSeconds (seconds);
	}

	public void ResumeGame()
	{
		
		Time.timeScale = 1; //Re run the game
	}

	//TODO: Fix it
	//Problem: It's freezing.
	public void MainMenu ()
	{
		SceneManager.LoadScene("startMenu");  
	}

	public void RestartGame()
	{
		SceneManager.LoadScene("hhod");  
	}

	public void ExitGame()
	{
		Application.Quit();
	}


}
