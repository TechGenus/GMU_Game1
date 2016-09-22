using UnityEngine;
using System.Collections;

public class ObstacleControl : MonoBehaviour {

	Rigidbody R;
	public float velocity;

	// Use this for initialization
	void Start () {
		R = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		R.AddForce (0, 0, velocity);

		if (gameObject.transform.position.y < -3) {
			Destroy (gameObject);
		}
	}
}
