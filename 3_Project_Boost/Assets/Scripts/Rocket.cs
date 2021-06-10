using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Rocket : MonoBehaviour
{
	 Rigidbody rigidBody;
	AudioSource audiosource;
	
	// Use this for initialization
	void Start ()
	{
		rigidBody = GetComponent<Rigidbody>();
		audiosource= GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		ProcessInput();
	}

	 void ProcessInput()
	 {
		 if (Input.GetKey(KeyCode.Space))
		 {
			 rigidBody.AddRelativeForce(Vector3.up);
			 if (!audiosource.isPlaying)
			 {
				 audiosource.Play();
			 }
			 else
			 {
				 audiosource.Stop();
			 }
		 }

		 if (Input.GetKey(KeyCode.A))
		 {
			 transform.Rotate(Vector3.forward);
		 }
		 else if (Input.GetKey(KeyCode.D))
		 {
			 transform.Rotate(-Vector3.forward);
		 }
	 }
}
