using UnityEngine;
using System.Collections;

public class MostrarIntentos : MonoBehaviour {

	public GameObject imagenIntento1;
	public GameObject imagenIntento2;
	public int intentos;

	// Use this for initialization
	void Start () {
	
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

}
