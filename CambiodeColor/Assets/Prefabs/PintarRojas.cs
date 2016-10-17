using UnityEngine;
using System.Collections;

public class PintarRojas : MonoBehaviour {
	public float colourChangeDelay = 1f;
	float currentDelay = 0f;
	bool colourChangeCollision = false;
	int counter =0;
    string hex;
	int bigint,r,g,b;
	public ParticleSystem ps2;
	public ParticleSystem[] pp;
	public GameObject luz;

	Color HexToColor(string hex)
	{
		byte r = byte.Parse(hex.Substring(0,2), System.Globalization.NumberStyles.HexNumber);
		byte g = byte.Parse(hex.Substring(2,2), System.Globalization.NumberStyles.HexNumber);
		byte b = byte.Parse(hex.Substring(4,2), System.Globalization.NumberStyles.HexNumber);
		return new Color32(r,g,b, 255);
	}


	void OnCollisionEnter(Collision other) {
		Debug.Log("Contact was made!");
		colourChangeCollision = true;
		currentDelay = Time.time + colourChangeDelay;
		counter++;
	}
	void checkColourChange()
	{        
		if(colourChangeCollision)
		{

			if (counter == 1) {
				transform.GetComponent<Renderer> ().material.color = HexToColor("FFC6C8");
				pp[0].startColor =HexToColor("FFC6C8");
				pp[0].enableEmission = true;
			}
			if (counter == 2) {
				transform.GetComponent<Renderer> ().material.color = HexToColor("FFA0A4");
				pp[0].startColor =HexToColor("FFA0A4");
				pp[0].enableEmission = true;
			}
		
			if (counter >= 3) {
				pp[0].startColor = Color.red;
				pp[0].enableEmission = true;
				transform.GetComponent<Renderer> ().material.color = Color.red;
				luz.SetActive(true); 
				Destroy (gameObject,5f);
			
			}
		

		}
	}

	void Start(){
		pp= this.GetComponentsInChildren<ParticleSystem> ();
		pp[0].enableEmission = false;
		luz.SetActive(false);
	}
	void Update()
	{	
		luz.SetActive(false);
		checkColourChange();
	}

}
