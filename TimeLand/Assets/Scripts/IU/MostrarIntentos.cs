using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MostrarIntentos : MonoBehaviour {

	public GameObject imagenIntento1;
	public GameObject imagenIntento2;
	public int intentos;
	public GameObject[] items=new GameObject[7];

	// Use this for initialization
	void Start () {
		mostrarItem ("");
	}
	
	// Update is called once per frame
	void Update () {

		actualizar();

	}

	void actualizar(){

		intentos = GameObject.Find ("Vida").GetComponent<Vida>().intentos;

		if(intentos==2){
			Destroy (imagenIntento2);
		}

		if(intentos==1){
			Destroy (imagenIntento1);
		}

	}

	public void mostrarItem(string name){

		if (name.Equals ("Cuerpo reloj")) {
				items [0].GetComponent<Image> ().enabled = true;
		} else {
				if (name.Equals ("Manecillas")) {
						items [1].GetComponent<Image> ().enabled = true;
				} else {
						if (name.Equals ("Cuerda reloj")) {
								items [2].GetComponent<Image> ().enabled = true;
						} else {
								if (name.Equals ("Reloj")) {
										items [3].GetComponent<Image> ().enabled = true;
								} else {
										if (name.Equals ("Lupa")) {
												items [4].GetComponent<Image> ().enabled = true;
										} else {
												if (name.Equals ("Llave")) {
														items [5].GetComponent<Image> ().enabled = true;
												} else {
														if (name.Equals ("Martillo")) {
																items [6].GetComponent<Image> ().enabled = true;
														}	
												}	
										}	
								}	
						}	
				}
		}

		if (Application.loadedLevelName == "OMEGA FINAL") {
				items [0].GetComponent<Image> ().enabled = true;
				items [1].GetComponent<Image> ().enabled = true;
				items [2].GetComponent<Image> ().enabled = true;
				items [3].GetComponent<Image> ().enabled = true;
				items [4].GetComponent<Image> ().enabled = true;
		}

		if (Application.loadedLevelName == "MUNDO PHI") {
			items [0].GetComponent<Image> ().enabled = true;
			items [1].GetComponent<Image> ().enabled = true;
			items [2].GetComponent<Image> ().enabled = true;
			items [3].GetComponent<Image> ().enabled = true;
			items [4].GetComponent<Image> ().enabled = true;
			items [5].GetComponent<Image> ().enabled = true;
			items [6].GetComponent<Image> ().enabled = true;
		}
	}
	
}
