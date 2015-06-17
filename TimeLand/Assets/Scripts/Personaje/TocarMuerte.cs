using UnityEngine;
using System.Collections;

public class TocarMuerte : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Muerte") {
			//Generar evento de reinicio
			Debug.Log("Evento de Muerte");
		}
					
	}

}
