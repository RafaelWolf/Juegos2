using UnityEngine;
using System.Collections;

public class PintarNegras : MonoBehaviour {
	public float colourChangeDelay = 1f;
	float currentDelay = 0f;
	bool colourChangeCollision = false;
	int counter =0;
	string hex;
	int bigint,r,g,b;
	public ParticleSystem ps2,ps3;
	public ParticleSystem[] p;
	public GameObject explosion; 

	Color HexToColor(string hex)
	{
		byte r = byte.Parse(hex.Substring(0,2), System.Globalization.NumberStyles.HexNumber);
		byte g = byte.Parse(hex.Substring(2,2), System.Globalization.NumberStyles.HexNumber);
		byte b = byte.Parse(hex.Substring(4,2), System.Globalization.NumberStyles.HexNumber);
		return new Color32(r,g,b, 255);
	}


	void OnCollisionEnter(Collision other) {
		//Debug.Log("Contact was made!");
		colourChangeCollision = true;
		currentDelay = Time.time + colourChangeDelay;
		counter++;
	}
	void checkColourChange()
	{        
		if(colourChangeCollision)
		{

			if (counter == 1) {
				transform.GetComponent<Renderer> ().material.color = HexToColor("83000D");
				//ps2.startColor =HexToColor("DB0017");
			//	ps2.enableEmission = true;
				p[0].startColor=HexToColor("83000D");
				p [0].enableEmission = true;
			}
			if (counter == 2) {
				transform.GetComponent<Renderer> ().material.color = HexToColor("000000");
			//	ps2.startColor =HexToColor("83000D");
			//	ps2.enableEmission = true;
				p[0].startColor=HexToColor("000000");
				p [0].enableEmission = true;
			}

			/*
			if (counter <= 3) {
				transform.GetComponent<Renderer> ().material.color = Color.yellow;
				if (Time.time > currentDelay) {
					transform.GetComponent<Renderer> ().material.color = Color.white;
					colourChangeCollision = false;
				}
			}*/


			if (counter >= 3) {
				p[0].startColor=HexToColor("FFFFFF");
				p [0].enableEmission = true;
			//	ps2.startColor = Color.gray;
			//	ps2.enableEmission = true;
				transform.GetComponent<Renderer> ().material.color = Color.black;
				GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
				Destroy(gameObject); // destroy the grenade
				Destroy(expl, 3); // delete the explosion after 3 seconds

			}
		}
	}

	void Start(){
		
	}
	void Update()
	{	
		//ps2 = this.GetComponentInChildren<ParticleSystem> ();
		//ps2.enableEmission = false;
		p = GetComponentsInChildren<ParticleSystem> ();
		p [0].enableEmission = false;
		//p [1].enableEmission = false;


		checkColourChange();
	}

}
