using UnityEngine;
using System.Collections;

public class Pintar : MonoBehaviour {
	

	void OnCollisionEnter(Collision col) {


			Destroy (col.gameObject);

	


	}
}
