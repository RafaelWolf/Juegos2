using UnityEngine;
using System.Collections;

public class PintarRojas : MonoBehaviour {
	public float colourChangeDelay = 1f;
	float currentDelay = 0f;
	bool colourChangeCollisionCA = false;
	bool colourChangeCollisionNI = false;
    int counterCA =0;
	int counterNI=0;
	int totalN = 0;
	int totalC=0;

    string hex;
	int bigint,r,g,b;
	private ParticleSystem pp;
	public GameObject luz;
	public static int recargaCA;
	public static int recargaNI;
	public GameObject[] pc3;
	public GameObject pzg;


	Color HexToColor(string hex)
	{
		byte r = byte.Parse(hex.Substring(0,2), System.Globalization.NumberStyles.HexNumber);
		byte g = byte.Parse(hex.Substring(2,2), System.Globalization.NumberStyles.HexNumber);
		byte b = byte.Parse(hex.Substring(4,2), System.Globalization.NumberStyles.HexNumber);
		return new Color32(r,g,b, 255);
	}

	void OnCollisionEnter(Collision other) {
		
		if(other.gameObject.name=="BrochaCarta" && recargaCA>0){
			colourChangeCollisionCA = true;
			currentDelay = Time.time + colourChangeDelay;
			counterCA++;
		}

		else if(other.gameObject.name=="Brocha" && recargaNI>0){
			colourChangeCollisionNI = true;
			currentDelay = Time.time + colourChangeDelay;
			counterNI++;
		}

			
	}
	void checkColourChangeNI()
	{        
		if(colourChangeCollisionNI)
		{

			if (counterNI == 1) {
				transform.GetComponent<Renderer> ().material.color = HexToColor("FFB0B0FF");
				pp.startColor =new Color (255f/255f,255f/255f,255f/255f,0.1f);
				pp.enableEmission = true;
			}
			if (counterNI == 2) {
				transform.GetComponent<Renderer> ().material.color = HexToColor("FF7B7BFF");
				pp.startColor = new Color (255f/255f,50f/255f,50f/255f,0.1f);
			
				pp.enableEmission = true;
			}
			if (counterNI >= 3) {
				pp.startColor = new Color (255/255f,0f,0f,0.1f);
				pp.enableEmission = true;
				transform.GetComponent<Renderer> ().material.color = Color.red;
				luz.SetActive(true); 
				Destroy (gameObject,5f);

				PintarNiño.contadorrojasnino++;

			}

		}
	}

	void checkColourChangeCA()
	{        
		if(colourChangeCollisionCA)
		{

			if (counterCA == 1) {
				transform.GetComponent<Renderer> ().material.color = HexToColor("FFB0B0FF");
				pp.startColor =new Color (255f/255f,255f/255f,255f/255f,0.1f);
				pp.enableEmission = true;
			}
			if (counterCA == 2) {
				transform.GetComponent<Renderer> ().material.color = HexToColor("FF7B7BFF");
				pp.startColor =new Color (255f/255f,50f/255f,50f/255f,0.1f);
			
				pp.enableEmission = true;
			}
		
			if (counterCA >= 3) {
				pp.startColor =  new Color (255/255f,0f,0f,0.1f);
				pp.enableEmission = true;
				transform.GetComponent<Renderer> ().material.color = Color.red;
				luz.SetActive(true); 
				Destroy (gameObject,5f);
				PintarCarta.contadorrojascarta++;

			}
		
		}
	}
		
	void Start(){
		pp= this.GetComponentInChildren<ParticleSystem> ();
		pp.enableEmission = false;
		luz.SetActive(false);
	}

	void Update()
	{	
		//luz.SetActive(false);
		checkColourChangeCA();
		checkColourChangeNI();
		recargaCA=PintarCarta.recargacarta;
		recargaNI = PintarNiño.recarganiño;
//		Debug.Log ("recargaNI"+recargaNI+"");
	}

}
