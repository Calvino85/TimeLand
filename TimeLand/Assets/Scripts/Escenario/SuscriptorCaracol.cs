using UnityEngine;
using System.Collections;

public class SuscriptorCaracol : MonoBehaviour {

	public bool caracol = false; 

	void Start ()
	{
		GameObject.Find ("Protagonista").GetComponent<Poderes> ().suscribir (this.gameObject);
	}
}
