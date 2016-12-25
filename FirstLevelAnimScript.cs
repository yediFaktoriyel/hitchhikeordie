// This script of the project is implemented by Ahmet Ozan Sivri. 
//The script simply manages the animation before the first level. 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Collections;

public class FirstLevelAnimScript : MonoBehaviour {


	public Button StartButton;

	// Use this for initialization
	void Start () {
		Button btn = StartButton.GetComponent<Button> ();
		btn.onClick.AddListener (ChangeScene);
	}

	public void ChangeScene()
	{
		SceneManager.LoadScene("hhod"); //Loads the first level 
	}
		
}
