// This script of the project is implemented by Ahmet Ozan Sivri. 
//The script simply manages the pause and exit options. 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Collections;

public class RightUpController : MonoBehaviour {

	//For the buttons on the game screen
	public Button stopGame;
	public Button exitGame;

	GameObject theIcon;
	public Button mute;
	public Sprite musicOn;
	public Sprite musicOff;
	public bool isMuted = false;


	public static bool inFun = false; //A flag which gives information to PauseMenuController.
	public static bool isPushed = false;

	void Start()
	{
		theIcon = GameObject.Find ("theIcon");
	}

	void Update()
	{
		Button btn = stopGame.GetComponent<Button> ();
		btn.onClick.AddListener (StopGame);

		if(Input.GetKey(KeyCode.P))
		{
			StopGame ();
		}

		if(Input.GetKey(KeyCode.R))
		{
			ResumeGame ();
		}

		Button btnE = exitGame.GetComponent<Button> ();
		btnE.onClick.AddListener (ExitGame);

		if(Input.GetKey(KeyCode.Escape))
		{
			isPushed = true;
		}

		mute.GetComponent<Button> ();
		mute.onClick.AddListener (MuteGame);

	}

	public void StopGame()
	{
		inFun = true;

	}


	public void ResumeGame()
	{
		inFun = false;

	}

	public void ExitGame()
	{
		isPushed = true;
	}

	public void MuteGame()
	{
		Debug.Log ("In the function");
		isMuted = true;
		AudioListener.pause = true;
		AudioListener.volume = 0;
	}

	//Double check here
	public void ChangeIcon()
	{
		if (isMuted == true) {
			theIcon.GetComponent<Image> ().sprite = musicOn;
		}
		else 
		{
			theIcon.GetComponent<Image> ().sprite = musicOff;
		}
	}
		
}
