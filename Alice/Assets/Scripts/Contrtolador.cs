using UnityEngine;
using System.Collections;

public class Contrtolador : MonoBehaviour {
	public GameObject brochacartacontrol,brochaninocontrol;
	public GameObject[] fuegosartificiales;
	public GameObject spawner,spawner2;

	private Spawner[] sp;
	//
	//
	// Use this for initialization
	void Start () {
		//brochacartacontrol = GameObject.Find ("brochacartacontrol");
		//brochaninocontrol = GameObject.Find ("brochaninocontrol");
		sp = GameObject.Find ("Plane").GetComponentsInChildren<Spawner>();

		fuegosartificiales [0].SetActive (false);
		fuegosartificiales [1].SetActive (false);
		sp[0].Startroutines ();
		sp[1].Startroutines ();

	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time>55f){
			PararJuego ();
			Comparacion ();
		}

	}
	void PararJuego(){
			
			sp[0].Pararroutines ();
			sp[1].Pararroutines ();

	}




	void Comparacion(){
		Animator anim=GameObject.Find ("N").GetComponent<Animator>();
		if(PintarCarta.contadorrojascarta>PintarNiño.contadorrojasnino){
			anim.SetBool ("ganar",true);
			fuegosartificiales [0].SetActive(true);
			Debug.Log ("CartaGano");
		}

		else {
			anim.SetBool ("ganar", false);
			fuegosartificiales [1].SetActive(true);
			Debug.Log ("Perdio");
		}
			
			
	}






}
