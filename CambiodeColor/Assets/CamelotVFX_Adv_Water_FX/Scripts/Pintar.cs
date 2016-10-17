using UnityEngine;
using System.Collections;

public class Pintar : MonoBehaviour {
	
	public  int recarga = 0;
	public int contadorrojas = 0;
	public ParticleSystem ps;

	void Start(){
		ps = this.GetComponentInChildren<ParticleSystem> ();
		ps.enableEmission = false;
	}
	void OnCollisionEnter(Collision col) {
		

		if (recarga <= 0 && ((col.gameObject.name == "PetalosR")||(col.gameObject.name == "PetalosB")))	{
			Debug.Log ("Recarga puto");
			ps.enableEmission = false;
		}

		if ((recarga > 0)) {
			if ((col.gameObject.name == "PetalosB")) {
				contadorrojas++;
				recarga--;
				Debug.Log ("LEDISTEROJO:"+contadorrojas.ToString()+"Municion"+recarga.ToString());
			}
			if ((col.gameObject.name == "PetalosR")) {
				contadorrojas--;
				recarga--;
				if (contadorrojas < 0)
					contadorrojas = 0;

				Debug.Log ("LEDISTEBLANCO:"+contadorrojas.ToString()+"Municion"+recarga.ToString());
			}
		}
		
		Debug.Log ("Nombre"+col.gameObject.name.ToString());
		if(col.gameObject.name=="Cubeta"){
			Recargar();
			Debug.Log ("MUNICION RECARGADA 100%");
			ps.enableEmission = true;
		}
   	Debug.Log ("Marcador"+contadorrojas.ToString());
	
	
	



	}

	public void Recargar(){
		recarga = 10;
	}








}
