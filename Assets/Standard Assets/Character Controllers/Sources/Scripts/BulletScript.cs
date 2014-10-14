using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour
{
	int lifespan = 1000;
	float speed = 10.0f;
	int numBullets = 0;

	// Use this for initialization
	void Start ()
	{
		numBullets++;
	}

	// Update is called once per frame
	void Update ()
	{
		//transform.Translate(Vector3.forward * speed * Time.deltaTime);
		float newX = transform.position.x + .25f;
		float y = transform.position.y;
		float z = transform.position.z;
		transform.position = new Vector3(newX, y , z);

		if(lifespan > 0)
		{
			lifespan--;
			speed *= 1.2f;
		}
		else{
			Destroy (this.gameObject);
		}

		if(numBullets  >= 5){
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.attachedRigidbody)
		{
			lifespan = 0;
			Destroy(other.gameObject);
			Destroy (this.gameObject);
			Debug.Log("collision");
		}
	}
}


