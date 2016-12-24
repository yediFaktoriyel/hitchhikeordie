
/*
This script is created by Burak as a whole.
TODO: Add car sound.
*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarScript : MonoBehaviour {

	PlayerScript getScriptRef;	// EKLENDi
	public GameObject tree;
	public GameObject sign;
	public static int Score = 0;		// EKLENDi

	void Start () {

	}

	void Update () {


	}

	//EKLENDi BAŞLANGıÇ

	void OnTriggerEnter(){

		if(!PlayerScript.isHitted){	

			Score += 100;

		}

	}

	//EKLENDi BiTiŞ

	void FixedUpdate(){

		transform.position += new Vector3 (0, 0, -1f); //Moves car forward every update.
		Vector3 v = transform.position;

		// If cars z value is more than 500, it spawns random trees depending on a randomly generated number

		if( v.z > 100){

			float ranGen = Random.Range (0, 100);

			if(ranGen < 2 && ranGen > 0f){

				GameObject treeSpawn = (GameObject)Instantiate(tree, new Vector3(v.x - 2.2f , 0.05f , v.z - 100), transform.rotation);

			}
		}
	}

}