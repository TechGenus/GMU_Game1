using UnityEngine;
using System.Collections;

public class spawnControl : MonoBehaviour {

	float spawnRate;
	float nextSpawn;
	float deleteTimer;

	public GameObject cube;

	// Use this for initialization
	void Start () {
		spawnRate = 1f;
		nextSpawn = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		print (cube);
		if (nextSpawn < Time.time) {
			float x = Random.Range (-0.9f, 0.75f);
			Vector3 pos = new Vector3 (x, 1, -8);
			Instantiate(cube, pos, Quaternion.identity);
			nextSpawn = Time.time + spawnRate;
		}
	}
}
