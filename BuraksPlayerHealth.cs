﻿/* This part of the code is reconstructed by Burak depending on the earlier "PlayerHealth" script of Ahmet */

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
	public static float zEnd;

	void Awake () {
		
		CurrentHealth = PlayerHealth;

	}

	void Start () {
	
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

			Vector3 v = transform.position;
			zEnd = v.z - 500.0f;
			Debug.Log (zEnd);
			Debug.Log (CarScript.isProtected);

		}

		else {

			isHit = true;
			HealthSlider.value -= Damage;
			hit.Play ();

		}

		if (HealthSlider.value <= 0) {

			SceneManager.LoadScene("gameOver");

		}
	}

	void OnTriggerExit(Collider other){
		
		isHit = false;

	}

	void Update () {

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

		Vector3 v1 = transform.position;

		if (chokeSlider.value > 1.90) {

			float baseDamage = 0.7f;
			CurrentHealth -= baseDamage;
			HealthSlider.value -= baseDamage;

			if (HealthSlider.value <= 0) {

				SceneManager.LoadScene("gameOver");

			}

		}

		if (v1.z < zEnd) {

			Debug.Log (v1.z);
			CarScript.isProtected = false;
			Debug.Log (CarScript.isProtected);

		}
	}
}
