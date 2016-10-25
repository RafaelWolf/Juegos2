using UnityEngine;
using System.Collections;

public class PintarCarta : MonoBehaviour {
	
	public static int recargacarta = 0;
	public static int contadorrojascarta = 0;
	public ParticleSystem ps;

	void Start(){
		ps = this.GetComponentInChildren<ParticleSystem> ();
		ps.enableEmission = false;
	}
	void Update(){
		recargacarta=recargacarta;
		//Debug.Log("Recarga"+recargacarta);
	}
	void OnCollisionEnter(Collision col) {
		

		if (recargacarta<= 0 && (col.gameObject.name == "PetalosB"))	{
			ps.enableEmission = false;
		}

		if(recargacarta> 0) {
			if ((col.gameObject.name == "PetalosB")) {
				recargacarta--;
			
				if (recargacarta < 0)
					recargacarta = 0;
			}
		}
		if(col.gameObject.name=="CubetaCarta"){
			Recargar();
			ps.enableEmission = true;
		}

	}

	public void Recargar(){
		recargacarta= 10000;
	}








}
