// need to know the time interval between spawns
// how far away from the center to spawn
// what to spawn

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NucleonSpawner : MonoBehaviour {

	public float timeBetweenSpawns;
	public float spawnDistance;
	public Nucleon[] nucleonPrefabs;
	public Transform cam;

	float timeSinceLastSpawn;

	void FixedUpdate() {
		timeSinceLastSpawn += Time.deltaTime;
		if (timeSinceLastSpawn >= timeBetweenSpawns) {
			timeSinceLastSpawn -= timeBetweenSpawns;
			SpawnNucleon ();
		}
	}

	void SpawnNucleon() {

		Nucleon prefab = nucleonPrefabs [Random.Range (0, nucleonPrefabs.Length)];
		Nucleon spawn = Instantiate<Nucleon> (prefab);

		spawn.transform.localPosition = Random.onUnitSphere * spawnDistance; 		//[example]








//		Vector3 newPos = new Vector3 (cam.position.x, cam.position.y,cam.position.z);
//		spawn.transform.position = newPos + (Random.onUnitSphere * spawnDistance);

//		spawn.transform.position = newPos;  [rui]

//		spawn.transform.rotation
	}
}