/* This part of the code is reconstructed by Burak depending on the earlier "PlayerHealth" script of Ahmet */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class BuraksPlayerHealth : MonoBehaviour {

	public float PlayerHealth = 100.0f;
	public float CurrentHealth;
	public float Damage = 20.0f;
	public AudioSource hit;
	public AudioSource pick;
	public Slider HealthSlider;
	public Slider chokeSlider;
	public Image DamageImage;
	public Color flashColor = new Color(1f, 0f, 0f, 0.1f);
	public float flashSpeed = 5f;
	PlayerScript getScriptRef;
	public GameObject HPSphere;
	public GameObject NoSpawnSphere;
	bool isHit;
	bool isProtected;

	public static bool isDeadOnFirstLevel = false;

	void Awake () {
		
		CurrentHealth = PlayerHealth;

	}

	void Start () {
		CarScript.Score = 0;
	}

	void OnTriggerEnter(Collider other){

		if (other.CompareTag ("HPSphere")) {

			pick.Play ();

			HealthSlider.value += 40.0f;

			if (HealthSlider.value > 100)
				HealthSlider.value = 100;

		}

		else if (other.CompareTag ("NoSpawnSphere")) {  // EDıT START

			pick.Play ();

			CarScript.isProtected = true;

			Debug.Log (CarScript.isProtected);

			//StartCoroutine (waiter());

			Debug.Log (CarScript.isProtected);
		}

		else {

			isHit = true;
			HealthSlider.value -= Damage;
			hit.Play ();

		}

		if (HealthSlider.value <= 0) {

			//Alternative TODO: Create anim before game over
			//SceneManager.LoadScene("gameOver");

		}
	}

	void OnTriggerExit(Collider other){
		
		isHit = false;

	}

	void Update () {

		if (CurrentHealth <= 0) {



		}

		if (isHit) {
			
			CurrentHealth = HealthSlider.value;
			DamageImage.color = flashColor;


		}

		else {
			
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

			float baseDamage = 0.7f;
			CurrentHealth -= baseDamage;
			HealthSlider.value -= baseDamage;

			if (HealthSlider.value <= 0) {
				isDeadOnFirstLevel = true;
				SceneManager.LoadScene("gameOver");
			}

		}
	}
}
