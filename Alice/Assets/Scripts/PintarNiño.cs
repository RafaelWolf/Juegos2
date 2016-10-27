using UnityEngine;
using System.Collections;

public class PintarNiño : MonoBehaviour {
	
	public static int recarganiño = 100000;
	public static int contadorrojasnino = 0;
	public ParticleSystem ps;

	void Start(){
		ps = this.GetComponentInChildren<ParticleSystem> ();
		ps.enableEmission = true;
	}

	void OnCollisionEnter(Collision col) {
		if (recarganiño <= 0 && ((col.gameObject.name == "PetalosB"))){
			Debug.Log ("recarganiño puto");
			ps.enableEmission = false;
		}

		if(recarganiño > 0){
			if ((col.gameObject.name == "PetalosR")) {

				recarganiño--;
			
				Debug.Log ("Municion"+recarganiño.ToString());
			}
		}
		
		Debug.Log ("Nombre"+col.gameObject.name.ToString());
		if(col.gameObject.name=="Cubeta"){
			Recargar();
			Debug.Log ("MUNICION RECARGADA 100%");
			ps.enableEmission = true;
		}
	   
	}
	void Update(){
		recarganiño=recarganiño;
	}
	public void Recargar(){
		recarganiño = 100000;
	}

}
