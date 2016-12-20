/*
  This portion of the project is implemented by Ahmet Ozan Sivri.
  12/20/2016
*/ 

//TODO: Write Comments
using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    public PlayerHealth playerHealthObject;
	public float restartDelay = 5f;

	Animator animate;
	float restart;

	// Use this for initialization
	void Awake () 
	{
		animate = GetComponent<Animator> ();
	}
		
	// Update is called once per frame
	void Update () 
	{
		if (playerHealthObject.currentHealth <= 0) 
		{
			animate.SetTrigger ("GameOver");

			restart += Time.deltaTime;

			if (restart >= restartDelay)
			{
				//TODO: Change the below with SceneManager.
				//Seems like LoadLevel does not exist anymore
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}
}
