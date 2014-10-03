using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	public GameObject Asteroid;
	private Vector3 xyz;
	public List<GameObject> asteroids;

	// Use this for initialization
	void Start () {

		asteroids = new List<GameObject>();

		for(int index = 0; index < 10; index++){

			xyz = new Vector3(Random.Range(0.0f,10.0f), Random.Range(-10.0f,10.0f),0);
			GameObject temp;
			temp = GameObject.Instantiate(Asteroid, xyz, Quaternion.identity) as GameObject;
			asteroids.Add(temp);

		}
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0 ; i < 10; i++){
			float x; 
			x = asteroids[i].transform.position.x - Random.Range(0.01f, 0.1f);
			float y;
			y = asteroids[i].transform.position.y;
			float z;
			z = 0.0f;
			asteroids[i].transform.position = new Vector3(x,y,z);

			if(asteroids[i].transform.position.x < -20.0f){

				asteroids[i].transform.position = new Vector3(20.0f, y, z);

			}
		}

	}
}
