using UnityEngine;
using System.Collections;

public class Empezar : MonoBehaviour {
	public GameObject spawner1;
	public GameObject spawner2;
	private 
	// Use this for initialization
	void Start () {
		StopAllCoroutines ();
	}
	
	public void ActivarSpawners(bool active){


		if (active) {
			StopAllCoroutines ();

		} else {
			//StartCoroutine("");
		}


	}


}
