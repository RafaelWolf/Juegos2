using UnityEngine;
using System.Collections;

public class Pintar : MonoBehaviour {
	
	public  int recarga = 0;
	public int contadorrojas = 0;
	void OnCollisionEnter(Collision col) {

		if (recarga == 0 && ((col.gameObject.tag == "Rosa1R")||(col.gameObject.tag == "Rosa2R")||(col.gameObject.tag == "Rosa3R")||(col.gameObject.tag == "Rosa4R")||(col.gameObject.tag == "Rosa5R")||(col.gameObject.tag == "Rosa1B")||(col.gameObject.tag == "Rosa2B")||(col.gameObject.tag == "Rosa3B")||(col.gameObject.tag == "Rosa4B")||(col.gameObject.tag == "Rosa5B")))	{
			Debug.Log ("Recarga amiguito");
		}
		if ((recarga != 0)) {
			if ((col.gameObject.tag == "Rosa1R")||(col.gameObject.tag == "Rosa2R")||(col.gameObject.tag == "Rosa3R")||(col.gameObject.tag == "Rosa4R")||(col.gameObject.tag == "Rosa5R")) {
				contadorrojas++;
				recarga--;
			}
			if ((col.gameObject.tag == "Rosa1B")||(col.gameObject.tag == "Rosa2B")||(col.gameObject.tag == "Rosa3B")||(col.gameObject.tag == "Rosa4B")||(col.gameObject.tag == "Rosa5B")) {
				contadorrojas--;
				recarga--;
			}
		}
		if(col.gameObject.tag=="Cubeta"){
			Recargar();
		}
		Debug.Log ("Marcador"+contadorrojas.ToString());
			
	}

	public void Recargar(){
		recarga = 3;
	}








}
