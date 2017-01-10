//This script created by Ahmet as whole to manage start screen. 

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour {

	public Button Level1;
	public Button Level2;
	public Button ExitGame;




	bool MouseFlag = false;


	// Use this for initialization
	void Start () {
		
		Level1 = Level1.GetComponent<Button> ();
		Level1.onClick.AddListener (JumptoLevel1);


		Level2 = Level2.GetComponent<Button> ();
		Level2.onClick.AddListener (JumptoLevel2);

		ExitGame = ExitGame.GetComponent<Button> ();
		ExitGame.onClick.AddListener (CloseGame);



	}
	

	void JumptoLevel1()
	{
		SceneManager.LoadScene ("hhod");
	}

	//TODO: Change LEVEL 2 
	void JumptoLevel2()
	{
		SceneManager.LoadScene ("LEVEL2");
	}

	void CloseGame()
	{
		Application.Quit();
	}





}
