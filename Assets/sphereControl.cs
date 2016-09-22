using UnityEngine;
using System.Collections;

public class sphereControl : MonoBehaviour {

	public float velocity;
	Transform T;
	Rigidbody R;

	// Use this for initialization
	void Start () {
		T = GetComponent<Transform> ();
		R = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			R.AddForce (velocity, 0, 0);
		}
		if (Input.GetKey (KeyCode.A)) {
			R.AddForce (-velocity, 0, 0);
		}
	}
}
