using UnityEngine;
using System.Collections;

public class PintarNiño : MonoBehaviour {
	
	public static int recarganiño = 0;
	public int contadorrojasniño = 0;
	public ParticleSystem ps;

	void Start(){
		ps = this.GetComponentInChildren<ParticleSystem> ();
		ps.enableEmission = false;
	}

	void OnCollisionEnter(Collision col) {
		
		if (recarganiño <= 0 && ((col.gameObject.name == "PetalosR")||(col.gameObject.name == "PetalosB")))	{
			Debug.Log ("recarganiño puto");
			ps.enableEmission = false;
		}

		if ((recarganiño > 0)) {
			if ((col.gameObject.name == "PetalosB")) {
				contadorrojasniño++;
				recarganiño--;
				Debug.Log ("LEDISTEROJO:"+contadorrojasniño.ToString()+"Municion"+recarganiño.ToString());
			}
			if ((col.gameObject.name == "PetalosR")) {
				contadorrojasniño--;
				recarganiño--;
				if (contadorrojasniño < 0)
					contadorrojasniño = 0;

				Debug.Log ("LEDISTEBLANCO:"+contadorrojasniño.ToString()+"Municion"+recarganiño.ToString());
			}
		}
		
		Debug.Log ("Nombre"+col.gameObject.name.ToString());
		if(col.gameObject.name=="Cubeta"){
			Recargar();
			Debug.Log ("MUNICION RECARGADA 100%");
			ps.enableEmission = true;
		}
	   	Debug.Log ("Marcador"+contadorrojasniño.ToString());
	}
	void Update(){
		recarganiño=recarganiño;
	}
	public void Recargar(){
		recarganiño = 100000;
	}

}
