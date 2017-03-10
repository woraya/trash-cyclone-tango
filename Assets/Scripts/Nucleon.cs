using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Nucleon : MonoBehaviour {

	public float attractionForce;
	public Transform mCamera;

	Rigidbody body;

	void Awake () {

		body = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		Vector3 dir = mCamera.transform.position - this.transform.position;
		dir.Normalize ();

		Vector3 force = dir * attractionForce;

		//Debug.Log ("Banana Force: " + force);

		body.AddForce (force);
	}



//	void Awake () {
//		body = GetComponent<Rigidbody> ();
//		
//	}
//
//	void FixedUpdate () {
//		body.AddForce (transform.localPosition * -attractionForce);
//		
//	}
}
