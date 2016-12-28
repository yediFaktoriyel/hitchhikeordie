/*
This script is created by Burak as a whole.
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarScript : MonoBehaviour {

	PlayerScript getScriptRef;	// EKLENDi
	public GameObject tree;
	public GameObject HPSphere;
	public GameObject NoSpawnSphere;
	public static int Score = 0;
	public static float Distance = 0;
	public static bool isProtected = false;

	void Awake () {

		GameObject treeSpawnFront1 = (GameObject)Instantiate(tree, new Vector3(43.31f , 0.05f , 7010), transform.rotation);
		GameObject treeSpawnBack1 = (GameObject)Instantiate(tree, new Vector3(43.31f , 0.05f , 6995), transform.rotation);

		GameObject treeSpawnFront2 = (GameObject)Instantiate(tree, new Vector3(43.31f , 0.05f , 4510), transform.rotation);
		GameObject treeSpawnBack2 = (GameObject)Instantiate(tree, new Vector3(43.31f , 0.05f , 4495), transform.rotation);

		GameObject treeSpawnFront3 = (GameObject)Instantiate(tree, new Vector3(43.31f , 0.05f , 2010), transform.rotation);
		GameObject treeSpawnBack3 = (GameObject)Instantiate(tree, new Vector3(43.31f , 0.05f , 1995), transform.rotation);

		GameObject HPCubeSpawn = (GameObject)Instantiate(HPSphere, new Vector3(43.31f , 2f , 4500), transform.rotation);
		GameObject NoSpawnCubeSpawn1 = (GameObject)Instantiate(NoSpawnSphere, new Vector3(43.31f , 2f , 8000), transform.rotation);
		GameObject NoSpawnCubeSpawn2 = (GameObject)Instantiate(NoSpawnSphere, new Vector3(43.31f , 2f , 2000), transform.rotation);

	}


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

		if( v.z > 100 && v.z < 1000 ) {

			float ranGen = Random.Range (0, 100);

			if(ranGen < 3.5 && ranGen > 0f){

				GameObject treeSpawn = (GameObject)Instantiate(tree, new Vector3(v.x - 2.2f , 0.05f , v.z - 100), transform.rotation);

			}
		}

		if (v.z <= 10) {
			Debug.Log ("In the Function");
			SceneManager.LoadScene("levelUp");

		}
	}

}