using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	public GameObject Asteroid;
	private Vector3 xyz;
	public List<GameObject> asteroids;
	public int score = 0;
	public GUIStyle font;

	// Use this for initialization
	void Start () {

		asteroids = new List<GameObject>();

		for(int index = 0; index < 25; index++){

			// Create starting position for asteroids, add 55 to make sure they arrive in sync with background music
			xyz = new Vector3(Random.Range(0.0f,20.0f) + 55.0f, Random.Range(-5.0f, 5.0f),0);
			GameObject temp;
			temp = GameObject.Instantiate(Asteroid, xyz, Quaternion.identity) as GameObject;
			temp.rigidbody.velocity = new Vector3(Random.Range(-3.5f, -3.0f), 0, 0);
			temp.rigidbody.mass = 3.0f;
			asteroids.Add(temp);

		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		score ++;
		for(int i = 0 ; i < 25; i++){
			/*float x; 
			x = asteroids[i].transform.position.x - Random.Range(0.01f, 0.1f);
			float y;
			y = asteroids[i].transform.position.y;
			float z;
			z = 0.0f;
			asteroids[i].transform.position = new Vector3(x,y,z);*/

			if(asteroids[i].gameObject == null){
				xyz = new Vector3(Random.Range(0.0f,20.0f) + 55.0f, Random.Range(-5.0f, 5.0f),0);
				GameObject temp;
				temp = GameObject.Instantiate(Asteroid, xyz, Quaternion.identity) as GameObject;
				temp.rigidbody.velocity = new Vector3(Random.Range(-3.5f, -3.0f), 0, 0);
				temp.rigidbody.mass = 3.0f;
				asteroids[i] = temp;
			}

			if(asteroids[i].transform.position.x < -10.0f || asteroids[i].transform.position.x > 76.0f || asteroids[i].transform.position.y > 10.0f || asteroids[i].transform.position.y < -10.0f){

				asteroids[i].transform.position = new Vector3(20.0f, Random.Range(-5.0f, 5.0f), 0.0f);
				asteroids[i].rigidbody.velocity = new Vector3(Random.Range(-3.5f, -3.0f),0,0);
				asteroids[i].rigidbody.mass = 3.0f;

			}


		}
	}


	//scoring label
	void OnGUI()
	{
		font.fontSize = 24;
		font.normal.textColor = Color.white;
		GUI.Label(new Rect(Screen.width * .05f, Screen.height * .1f, Screen.width * .45f, Screen.height * .5f),"Score: " + score.ToString(), font);
	}
}
