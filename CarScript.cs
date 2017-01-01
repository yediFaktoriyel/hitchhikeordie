/*
This script is created by Burak as a whole.
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarScript : MonoBehaviour {

	PlayerScript getScriptRef;
	public GameObject tree;
	public GameObject HPSphere;
	public GameObject NoSpawnSphere;
	public GameObject Enviro0;
	public GameObject Enviro1;
	public float enviroUpdateLocation;
	public static int Score = 0;
	public static float Distance = 0;
	public static bool isProtected = false;
	public int enviroCnt;

	void Awake () {

		GameObject treeSpawnFront1 = (GameObject)Instantiate(tree, new Vector3(43.31f , 0.05f , 2760), transform.rotation);
		GameObject treeSpawnBack1 = (GameObject)Instantiate(tree, new Vector3(43.31f , 0.05f , 2745), transform.rotation);

		GameObject treeSpawnFront2 = (GameObject)Instantiate(tree, new Vector3(43.31f , 0.05f , 4010), transform.rotation);
		GameObject treeSpawnBack2 = (GameObject)Instantiate(tree, new Vector3(43.31f , 0.05f , 3995), transform.rotation);

		GameObject treeSpawnFront3 = (GameObject)Instantiate(tree, new Vector3(43.31f , 0.05f , 1510), transform.rotation);
		GameObject treeSpawnBack3 = (GameObject)Instantiate(tree, new Vector3(43.31f , 0.05f , 1495), transform.rotation);

		GameObject HPCubeSpawn = (GameObject)Instantiate(HPSphere, new Vector3(43.31f , 2f , 2750), transform.rotation);
		GameObject NoSpawnCubeSpawn1 = (GameObject)Instantiate(NoSpawnSphere, new Vector3(43.31f , 2f , 4000), transform.rotation);
		GameObject NoSpawnCubeSpawn2 = (GameObject)Instantiate(NoSpawnSphere, new Vector3(43.31f , 2f , 1500), transform.rotation);

	}


	void Start () {

		enviroUpdateLocation = -2750.0f;
		enviroCnt = 1;

	}

	void Update () {

		Vector3 v = transform.position;
		Distance = 5495 - v.z;

	}

	void EnviroSpawn(){

		if (enviroCnt == 1) {

			Enviro1.transform.position -= new Vector3 (0, 0, 11000f);
			enviroCnt = 0;

		}

		if (enviroCnt == 0) {

			Enviro1.transform.position -= new Vector3 (0, 0, 11000f);
			enviroCnt = 1;

		}

		enviroUpdateLocation -= 5500.0f;

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



		if (v.z < enviroUpdateLocation + 0.5f && v.z > enviroUpdateLocation - 0.5f) {

			EnviroSpawn ();

		}

		/////// UPDATE START

		if (v.z > 5455) {
			
			float l = 5496 - v.z;

			transform.position += new Vector3 (0, 0, l * -0.02f);

		}

		////// UPDATE END

		else {
			
			transform.position += new Vector3 (0, 0, -1f); //Moves car forward every update.

		}
			

		if( v.z > 5000 && isProtected == false){

			float ranGen = Random.Range (0, 100);

			if(ranGen <= 1 && ranGen > 0f){

				GameObject treeSpawn = (GameObject)Instantiate(tree, new Vector3(v.x - 2.2f , 0.05f , v.z - 100), transform.rotation);

			}
		}

		if( v.z > 3000 && v.z < 5000 && isProtected == false){

			float ranGen = Random.Range (0, 100);

			if(ranGen <= 2 && ranGen > 0f){

				GameObject treeSpawn = (GameObject)Instantiate(tree, new Vector3(v.x - 2.2f , 0.05f , v.z - 100), transform.rotation);

			}
		}

		if( v.z > 1500 && v.z < 3000 && isProtected == false){

			float ranGen = Random.Range (0, 100);

			if(ranGen <= 2.5 && ranGen > 0f){

				GameObject treeSpawn = (GameObject)Instantiate(tree, new Vector3(v.x - 2.2f , 0.05f , v.z - 100), transform.rotation);

			}
		}

		if( v.z > 500 && v.z < 1500 && isProtected == false){

			float ranGen = Random.Range (0, 100);

			if(ranGen <= 2.7 && ranGen > 0f){

				GameObject treeSpawn = (GameObject)Instantiate(tree, new Vector3(v.x - 2.2f , 0.05f , v.z - 100), transform.rotation);

			}
		}

		if( v.z < 500 && isProtected == false) {

			float ranGen = Random.Range (0, 100);

			if(ranGen < 3.5 && ranGen > 0f){

				GameObject treeSpawn = (GameObject)Instantiate(tree, new Vector3(v.x - 2.2f , 0.05f , v.z - 100), transform.rotation);

			}
		}
	}

}