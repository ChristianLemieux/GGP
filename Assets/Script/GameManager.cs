using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject Asteroid;
	private Vector3 xyz;

	// Use this for initialization
	void Start () {
		Asteroid = GameObject.Find("Asteroid");
		xyz = new Vector3(30, Random.Range(0,30),0);
		Instantiate(Asteroid, xyz, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
