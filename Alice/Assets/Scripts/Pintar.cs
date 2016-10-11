using UnityEngine;
using System.Collections;

public class Pintar : MonoBehaviour {
	
	public  int recarga = 0;
	public int contadorazul = 0;
	public int contadorrojas = 0;
	void OnCollisionEnter(Collision col) {


		if (recarga == 0 && ((col.gameObject.tag == "PelotaAzul")||(col.gameObject.tag == "PelotaRoja")))	{
			Debug.Log ("Recarga amiguito");
		}

	

		if(col.gameObject.tag=="Cubeta"){
			Recargar();
		}

		if ((!recarga == 0)) {
			if (col.gameObject.tag == "PelotaAzul") {
				contadorazul++;
			}
			if (col.gameObject.tag == "PelotaRoja") {
				contadorazul++;
			}


	

		}
			
	}

	public void Recargar(){
		recarga = 3;
	}








}
