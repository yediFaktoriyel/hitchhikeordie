/*
  This portion of the project is implemented by Ahmet Ozan Sivri.
  When I implemented this, I referenced by a video tutorial:
  https://unity3d.com/learn/tutorials/projects/survival-shooter/player-health?playlist=17144
*/ 

using UnityEngine;

using UnityEngine.UI; //To use UI objects like slider and images etc.

<<<<<<< HEAD
public class PlayerHealth : MonoBehaviour {

	public Slider HealthSlider;
=======
using System.Collections;public class PlayerHealth : MonoBehaviour {    public Slider HealthSlider;

>>>>>>> 918b186dd80346a67e41553d5f155e1150872081
	public Image DamageImage;

	//TODO: Implement some voices for low health and being dead.

	public float flashSpeed = 5f;

	public Color flashColor = new Color(1f, 0f, 0f, 0.1f);
<<<<<<< HEAD
	public int startingHealth = 100;
	public int currentHealth;
=======

	public int startingHealth = 100;

	public int currentHealth;

>>>>>>> 918b186dd80346a67e41553d5f155e1150872081
	PlayerScript getScriptRef;
	bool isHit;

<<<<<<< HEAD
	bool dead;
	bool gotDamage; 

	// Use this for initialization
=======
	bool isHit;    bool dead;

	bool gotDamage;

>>>>>>> 918b186dd80346a67e41553d5f155e1150872081
	void Start () {
		
		currentHealth = startingHealth;

<<<<<<< HEAD
	}

	// Update is called once per frame
	void Update () {
		isHit = PlayerScript.isHitted;
		if (isHit == true) {
=======
	}    // Update is called once per frame

	void Update () {

		isHit = PlayerScript.isHitted;

		if (isHit == true) {

>>>>>>> 918b186dd80346a67e41553d5f155e1150872081
			//Shows a red splash screen

			DamageImage.color = flashColor;
<<<<<<< HEAD
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

=======

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

			//gotDamage = true;

			Debug.Log("Burda sorun yok");

			//Decrease the health by 20

			currentHealth -= 10;

			Debug.Log (currentHealth);

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
>>>>>>> 918b186dd80346a67e41553d5f155e1150872081

}