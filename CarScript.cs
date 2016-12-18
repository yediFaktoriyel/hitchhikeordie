using UnityEngine;
using System.Collections;

public class CarScript : MonoBehaviour {

	public GameObject tree;
	public GameObject sign;

	void Start () {
	
	}

	void Update () {
		
		transform.position += new Vector3 (0, 0, -0.2f); //Moves car forward every update.
		Vector3 v = transform.position;

		// If cars z value is more than 500, it spawns random trees depending on a randomly generated number

		if( v.z > 500){

			float ranGen = Random.Range (0, 100);

			if(ranGen < 2 && ranGen > 0f){
				
			GameObject treeSpawn = (GameObject)Instantiate(tree, new Vector3(v.x - 2f , 0.05f , v.z - 100), transform.rotation);
			
			}
		}

	}
		
}
