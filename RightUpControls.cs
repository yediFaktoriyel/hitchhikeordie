// This script of the project is implemented by Ahmet Ozan Sivri. 
//The script manages the up right pause and exit buttons. 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Collections;

public class RightUpControls : MonoBehaviour {


	public Button PauseGame;
	public Button ESCGame;

	Animator anim;


	// Use this for initialization
	void Start () {
		
	}

	void Update(){
		PauseGame.onClick.AddListener (StopGame);
		ESCGame.onClick.AddListener (ExitGame);

		if(Input.GetKey(KeyCode.Escape)){
			StopGame ();
		}
		if(Input.GetKey(KeyCode.P)){
			StopGame ();
		}
	}

	//Not entering to the function.
	//TODO: Fix it!!
	public void StopGame()
	{
		Debug.Log ("In StopGame()");
		anim = (Animator)GetComponent ("PauseMenu");
	}

	public void ExitGame()
	{
		Application.Quit();
	}

}
