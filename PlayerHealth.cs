/*
  This portion of the project is implemented by Ahmet Ozan Sivri.
  When I implemented this, I referenced by a video tutorial:
  https://unity3d.com/learn/tutorials/projects/survival-shooter/player-health?playlist=17144
*/ 

using UnityEngine;
using UnityEngine.UI; //To use UI objects like slider and images etc.
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public int startingHealth = 100;
	public int currentHealth;
	public Slider HealthSlider;
	public Image DamageImage;
	//TODO: Implement some voices for low health and being dead.
	public float flashSpeed = 5f;
	public Color flashColor = new Color(1f, 0f, 0f, 0.1f);

	PlayerScript getScriptRef;

	bool dead;
	bool gotDamage; 
	// Use this for initialization
	void Start () {
		GameObject playerScript = GameObject.Find("PlayerScript");
		PlayerScript getScriptRef = playerScript.GetComponent<PlayerScript> ();
		//Initialize the current health as 100
		currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerScript.isHitted == true) {
			//Shows a red splash screen
			DamageImage.color = flashColor;
			//Decrease the health by 20
			currentHealth = currentHealth - 20;
			if (currentHealth <= 0) 
			{
				dead = true;
				Debug.Log ("UR DED");
			}
		}
		else
		{
			//TODO: Check the output
		}
		gotDamage = false;
	}
}
