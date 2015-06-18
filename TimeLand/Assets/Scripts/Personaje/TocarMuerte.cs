using UnityEngine;
using System.Collections;

public class TocarMuerte : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Muerte") {
			GameObject.Find("Vida").GetComponent<Vida>().vida = 0;
			GameObject.Find("Vida").GetComponent<Vida>().revisarMuerte();
		}			
	}
}
