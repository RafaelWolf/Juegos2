using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject[] enemies;
	public Vector3 spawnValues;
	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeastWait;
	public int startWait;
	public bool stop;
	public float delay;
	public GameObject prefab;
	public GameObject prefab2;
	int randEnemy;
	// Use this for initialization
	void Start () {
		//StartCoroutine (waitSpawner());
	}
	public void Pararroutines(){
		StopAllCoroutines ();
	}
	public void Startroutines(){
		StartCoroutine (waitSpawner());
	}

	// Update is called once per frame
	void Update () {
		spawnWait = Random.Range (spawnLeastWait,spawnMostWait);
	}

	IEnumerator waitSpawner(){
		yield return new WaitForSeconds (startWait);
	
			while (!stop) {
			
				randEnemy = Random.Range (0, 1);
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), 1, Random.Range (-spawnValues.z, spawnValues.z));
				prefab = Instantiate (enemies [randEnemy], spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation) as GameObject;
				prefab.transform.parent = GameObject.Find ("Spawn").transform;
				Destroy (prefab, delay);
				yield return new WaitForSeconds (spawnWait);
				Debug.Log ("Tiempo"+Time.time+"");			


			}
		
	}

}
