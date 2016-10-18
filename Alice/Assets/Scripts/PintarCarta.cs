using UnityEngine;
using System.Collections;

public class PintarCarta : MonoBehaviour {
	
	public  int recargacarta = 0;
	public int contadorrojascarta = 0;
	public ParticleSystem ps;

	void Start(){
		ps = this.GetComponentInChildren<ParticleSystem> ();
		ps.enableEmission = false;
	}
	void Update(){
		recargacarta = recargacarta;
	}

	void OnCollisionEnter(Collision col) {
		

		if (recargacarta<= 0 && ((col.gameObject.name == "PetalosR")||(col.gameObject.name == "PetalosB")))	{
			//Debug.Log ("recargacartaputo");
			ps.enableEmission = false;
		}

		if ((recargacarta> 0)) {
			if ((col.gameObject.name == "PetalosB")) {
				contadorrojascarta++;
				recargacarta--;
			//	Debug.Log ("LEDISTEROJO:"+contadorrojascarta.ToString()+"Municion"+recargacarta.ToString());
			}
			if ((col.gameObject.name == "PetalosR")) {
				contadorrojascarta--;
				recargacarta--;
				if (contadorrojascarta < 0)
					contadorrojascarta = 0;

			//	Debug.Log ("LEDISTEBLANCO:"+contadorrojascarta.ToString()+"Municion"+recargacarta.ToString());
			}
		}
		
//		Debug.Log ("Nombre"+col.gameObject.name.ToString());
		if(col.gameObject.name=="CubetaCarta"){
			Recargar();
			//Debug.Log ("MUNICION RECARGADA 100%");
			ps.enableEmission = true;
		}
   	//Debug.Log ("Marcador"+contadorrojascarta.ToString());

	}

	public void Recargar(){
		recargacarta= 10;
	}








}
