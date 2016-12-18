/*
  This portion of the project is implemented by Ahmet Ozan Sivri.
  When I implemented this, I referenced by a video tutorial:
  https://unity3d.com/learn/tutorials/projects/survival-shooter/player-health?playlist=17144
*/ 

using UnityEngine;
using UnityEngine.UI; //To use UI objects like slider and images etc.
using System.Collections;

public class PlayerHealth : MonoBehaviour {    public Slider HealthSlider;

	public Image DamageImage;

	//TODO: Implement some voices for low health and being dead.

	public float flashSpeed = 5f;
	public Color flashColor = new Color(1f, 0f, 0f, 0.1f);
	public int startingHealth = 100;
	public int currentHealth;
	PlayerScript getScriptRef;
	bool isHit;
	bool dead;
	bool gotDamage; 



	// Use this for initialization
	void Start () {
		
		currentHealth = startingHealth;
	}

  	// Update is called once per frame
	void Update () {

	isHit = PlayerScript.isHitted;

	if (isHit == true) {
				
		//Shows a red splash screen

		DamageImage.color = flashColor;
		Damage ();
	}
	else
	{
		DamageImage.color = Color.Lerp (DamageImage.color, Color.clear, flashSpeed * Time.deltaTime);
	}
	gotDamage = false;
	}

	public void Damage()
	{
		gotDamage = true;
		Debug.Log("Burda sorun yok");

		//Decrease the health by 20
		currentHealth -= 10; //Changed by Burak
		HealthSlider.value = currentHealth;
		if (currentHealth <= 0) 
		{
			alreadyDead ();
			Debug.Log ("UR DED");
		}
	}

	void alreadyDead()
	{
		//TODO: Add animations and disable feature to here
	
		dead = true;
	}

}