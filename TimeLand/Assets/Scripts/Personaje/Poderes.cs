using UnityEngine;
using System.Collections;

public class Poderes : MonoBehaviour {

	public bool poderCaracol=false;
	public bool poderBurbuja=false;
	public bool poderRayo=false;
	public float tiempo = 5;
	public SpriteRenderer burbujaPoder;

	void OnTriggerEnter2D(Collider2D coll) {

		if(coll.gameObject.tag == "Poderes"){
			if(coll.gameObject.name == "Caracol"){
				StartCoroutine(Caracol());
			}
			
			if(coll.gameObject.name == "Burbuja"){
				StartCoroutine(Burbuja());
			}
			
			if(coll.gameObject.name == "Rayo"){
				StartCoroutine(Rayo());
			}

			Destroy(coll.gameObject);
		}
	}

	IEnumerator Caracol()
	{
		poderCaracol = true;
		yield return new WaitForSeconds(tiempo);
		poderCaracol = false;
	}

	IEnumerator Burbuja()
	{
		poderBurbuja = true;
		burbujaPoder.enabled = true;
		yield return new WaitForSeconds(tiempo);
		poderBurbuja = false;
		burbujaPoder.enabled = false;
	}

	IEnumerator Rayo()
	{
		poderRayo = true;
		yield return new WaitForSeconds(tiempo);
		poderRayo = false;
	}
}
