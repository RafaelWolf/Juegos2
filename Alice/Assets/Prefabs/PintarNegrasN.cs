using UnityEngine;
using System.Collections;

public class PintarNegrasN : MonoBehaviour {
	public float colourChangeDelay = 1f;
	float currentDelay = 0f;
	bool colourChangeCollision = false;
	int counter =0;
	string hex;
	int bigint,r,g,b;
	public ParticleSystem ps2,ps3;
	public ParticleSystem[] p;
	public GameObject explosion; 
	private static int recargaNI;

	Color HexToColor(string hex)
	{
		byte r = byte.Parse(hex.Substring(0,2), System.Globalization.NumberStyles.HexNumber);
		byte g = byte.Parse(hex.Substring(2,2), System.Globalization.NumberStyles.HexNumber);
		byte b = byte.Parse(hex.Substring(4,2), System.Globalization.NumberStyles.HexNumber);
		return new Color32(r,g,b, 255);
	}


	void OnCollisionEnter(Collision other) {
		//Debug.Log("Contact was made!");

		if(other.gameObject.name=="Brocha" && recargaNI>0){
			colourChangeCollision = true;
			currentDelay = Time.time + colourChangeDelay;
			counter++;
		}

	}
	void checkColourChange()
	{        
		if(colourChangeCollision)
		{

			if (counter == 1) {
				transform.GetComponent<Renderer> ().material.color = HexToColor("83000D");
				p[0].startColor=HexToColor("83000D");
				p [0].enableEmission = true;
			}
			if (counter == 2) {
				transform.GetComponent<Renderer> ().material.color = HexToColor("000000");
				p[0].startColor=HexToColor("000000");
				p [0].enableEmission = true;
			}
			if (counter >= 3) {
				p[0].startColor=HexToColor("FFFFFF");
				p [0].enableEmission = true;
				transform.GetComponent<Renderer> ().material.color = Color.black;
				GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
				Destroy(gameObject); // destroy the grenade
				Destroy(expl, 3); // delete the explosion after 3 seconds

			}
		}
	}

	void Update()
	{	

		p = GetComponentsInChildren<ParticleSystem> ();
		p [0].enableEmission = false;
		recargaNI=PintarNiño.recarganiño;
		checkColourChange();
	}

}
