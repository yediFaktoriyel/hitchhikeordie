// This script of the project is implemented by Ahmet Ozan Sivri. 
//The script simply manages the start scene. 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Collections;

public class StartMenu : MonoBehaviour {


	public Button startText;
	public Button exitText;

	// Use this for initialization
	void Start () {
		Button btn = startText.GetComponent<Button> ();
		btn.onClick.AddListener (ChangeScene);
		Button btnE = exitText.GetComponent<Button> ();
		btnE.onClick.AddListener (ExitGame);
	}
		
	public void ChangeScene()
	{
		SceneManager.LoadScene("story"); //Loads the first level 
	}

	public void ExitGame()
	{
		Application.Quit();
	}




		
}
