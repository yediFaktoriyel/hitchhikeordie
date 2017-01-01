// This script of the project is implemented by Ahmet Ozan Sivri. 
//The script simply manages the pause and exit options. 

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Collections;


public class PauseMenuController : MonoBehaviour {

	 public Animator anim;
	 public GameObject PauseMenuCanvas;
	 
	 bool isStopped = false; //A controller to help to understand if game is paused or not.

	// Use this for initialization
	void Start () {
		
		anim.GetComponent<Animator> ();
		PauseMenuCanvas.GetComponent<Canvas> ();

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.P))
			{
			PlayAnimStop (); //Stop Game function is running at the last frame of the stop animation.

			}
		 if (Input.anyKey && isStopped == true) {
			ResumeGame ();
		}
	}
		


	void PlayAnimStop()
	{
		Debug.Log ("Animating");
		anim.SetInteger ("isPushed", 1);
		anim.SetBool ("isResume", false);

	}
	public void StopGame()
	{
		Debug.Log ("In Stop");
		isStopped = true;
		Time.timeScale = 0;

	}

	public void PlayAnimRun()
	{
		
		Debug.Log ("in Animation");
		anim.SetBool ("isDone", true);
		anim.Play ("Resume");
		anim.SetBool ("isResume", true);
		anim.SetInteger ("isPushed", 0);
	}

	public void ResumeGame()
	{
		Time.timeScale = 1;
		PlayAnimRun ();
		isStopped = false;
	}
		
}
