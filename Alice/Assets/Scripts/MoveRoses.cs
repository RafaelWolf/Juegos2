using UnityEngine;
using System.Collections;

public class MoveRoses : MonoBehaviour {
	public float movementSpeed;
	public bool canMove=true;
	// Update is called once per frame
	void Update ()
	{
		
			if (this.canMove) {
			this.transform.Translate (Vector3.up * this.movementSpeed * Time.deltaTime);
			}


	
	}
}
