// This script of the project is implemented by Ahmet Ozan Sivri. 
//The script simply manages two buttons in choose level scene. 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Collections;

public class ChooseLevelController : MonoBehaviour {


	public Button levelOne;
	public Button levelTwo;

	// Use this for initialization
	void Start () {
		Button btn = levelOne.GetComponent<Button> ();
		btn.onClick.AddListener (OpenUpFirstLevel);
		Button btnE = levelTwo.GetComponent<Button> ();
		btnE.onClick.AddListener (OpenUpSecondLevel);
	}

	public void OpenUpFirstLevel()
	{
		SceneManager.LoadScene("hhod"); //Loads the first level 
	}

	public void OpenUpSecondLevel()
	{
		SceneManager.LoadScene("hhod"); //Loads the first level 
	}

}
