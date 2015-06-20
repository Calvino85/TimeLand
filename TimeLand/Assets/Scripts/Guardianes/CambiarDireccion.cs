using UnityEngine;
using System.Collections;

public class CambiarDireccion : MonoBehaviour {

	private MoverGuardian padre;

	// Use this for initialization
	void Start () {
		padre = gameObject.transform.GetComponentInParent<MoverGuardian>();
	}

	void OnCollisionEnter2D(Collision2D coll) {	
		if(coll.gameObject.tag == "Player"){
			padre.direccion = !padre.direccion;
		}
	}
}
