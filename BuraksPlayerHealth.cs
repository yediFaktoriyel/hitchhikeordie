using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuraksPlayerHealth : MonoBehaviour {

	public int PlayerHealth = 100;
	public int CurrentHealth;
	public int Damage = 20;
	public Slider HealthSlider;
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


	}

	void OnTriggerExit(Collider other){
		
		isHit = false;

	}

	void Update () {

		if (CurrentHealth <= 0){



		}

		if(isHit){
			
			Debug.Log ("Şimdilik iyi.");
			CurrentHealth -= Damage;
			DamageImage.color = flashColor;

		}

		else {
			
			DamageImage.color = Color.Lerp (DamageImage.color, Color.clear, flashSpeed * Time.deltaTime);

		}
	
	}

	void FixedUpdate(){

	}
}
