
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
	public static int Score = 0;
	public static float Distance = 0;

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

		Vector3 v = transform.position;


		if (v.z > 8895) {
			
			float movementTime = Time.fixedTime;
			transform.position += new Vector3 (0, 0, movementTime * -0.2f);
			Distance += movementTime * 1;
		}

		else {
			
			transform.position += new Vector3 (0, 0, -1f); //Moves car forward every update.
			Distance += 1;

		}

		// If cars z value is more than 500, it spawns random trees depending on a randomly generated number

		if( v.z > 8000){

			float ranGen = Random.Range (0, 100);

			if(ranGen <= 1 && ranGen > 0f){

				GameObject treeSpawn = (GameObject)Instantiate(tree, new Vector3(v.x - 2.2f , 0.05f , v.z - 100), transform.rotation);

			}
		}

		if( v.z > 5000 && v.z < 8000){

			float ranGen = Random.Range (0, 100);

			if(ranGen <= 2 && ranGen > 0f){

				GameObject treeSpawn = (GameObject)Instantiate(tree, new Vector3(v.x - 2.2f , 0.05f , v.z - 100), transform.rotation);

			}
		}

		if( v.z > 2500 && v.z < 5000){

			float ranGen = Random.Range (0, 100);

			if(ranGen <= 2.5 && ranGen > 0f){

				GameObject treeSpawn = (GameObject)Instantiate(tree, new Vector3(v.x - 2.2f , 0.05f , v.z - 100), transform.rotation);

			}
		}

		if( v.z > 1000 && v.z < 2500){

			float ranGen = Random.Range (0, 100);

			if(ranGen <= 2.7 && ranGen > 0f){

				GameObject treeSpawn = (GameObject)Instantiate(tree, new Vector3(v.x - 2.2f , 0.05f , v.z - 100), transform.rotation);

			}
		}

		if( v.z < 1000 ) {

			float ranGen = Random.Range (0, 100);

			if(ranGen < 3 && ranGen > 0f){

				GameObject treeSpawn = (GameObject)Instantiate(tree, new Vector3(v.x - 2.2f , 0.05f , v.z - 100), transform.rotation);

			}
		}
	}

}