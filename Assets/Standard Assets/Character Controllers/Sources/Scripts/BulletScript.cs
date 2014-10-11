using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour
{
	int lifespan = 100000;
	float speed = 10.0f;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		transform.Translate(Vector3.forward * speed * Time.deltaTime);

		if(lifespan > 0)
		{
			lifespan--;
			speed *= 1.2f;
		}
		else{
			Destroy (transform.gameObject);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.attachedRigidbody)
		{
			lifespan = 0;
			Destroy(other.gameObject);
		}
	}
}


