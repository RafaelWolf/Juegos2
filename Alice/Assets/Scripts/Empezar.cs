using UnityEngine;
using System.Collections;

public class Empezar : MonoBehaviour {
	public GameObject spawner1;
	public GameObject spawner2;

	// Use this for initialization
	void Start () {
		spawner1.SetActive (false);
		spawner2.SetActive (false);
	}
	
	public void ActivarSpawners(bool active){
		if (active) {
			spawner1.SetActive (true);
			spawner2.SetActive (true);
		} else {
			spawner1.SetActive (false);
			spawner2.SetActive (false);
		}


	}


}
