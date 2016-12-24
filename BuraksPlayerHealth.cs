/* This part of the code is reconstructed by Burak depending on the earlier "PlayerHealth" script of Ahmet */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BuraksPlayerHealth : MonoBehaviour {

	public float PlayerHealth = 100.0f;
	public float CurrentHealth;
	public float Damage = 20.0f;
	public Slider HealthSlider;
	public Slider chokeSlider;
	public Image DamageImage;
	public Color flashColor = new Color(1f, 0f, 0f, 0.1f);
	public float flashSpeed = 5f;
	PlayerScript getScriptRef;
	bool isHit;

	void Awake () {
		
		CurrentHealth = PlayerHealth;

	}

	void Start () {
	
	}

	void OnTriggerEnter(Collider other){

		isHit = true;
		HealthSlider.value -= Damage;

		if (HealthSlider.value <= 0) {

			SceneManager.LoadScene("gameOver");

		}
	}

	void OnTriggerExit(Collider other){
		
		isHit = false;

	}

	void Update () {

		if (CurrentHealth <= 0) {



		}

		if (isHit) {
			
			Debug.Log ("Şimdilik iyi.");
			CurrentHealth -= Damage;
			DamageImage.color = flashColor;

		} else {
			
			DamageImage.color = Color.Lerp (DamageImage.color, Color.clear, flashSpeed * Time.deltaTime);

		}

		if (Input.GetKey (KeyCode.LeftArrow)) {

			float timeCounter;
			timeCounter = Time.deltaTime;						//The choke slider starts to fill 1 per second as the right arrow held...
			chokeSlider.value += timeCounter * 1;

		}

		if (Input.GetKey (KeyCode.LeftArrow) == false) {

			if (chokeSlider.value > 0) {

				float timeCounter;
				timeCounter = Time.deltaTime;					//... and it slowly cools down if released.
				chokeSlider.value -= timeCounter * 1;

			}
	
		}
			
	}


	void FixedUpdate(){

		if (chokeSlider.value > 1.90) {

			float timePassed;
			float baseDamage = 0.2f;
			timePassed = Time.deltaTime;
			CurrentHealth -= baseDamage;
			HealthSlider.value -= baseDamage;

		}
	}
}
