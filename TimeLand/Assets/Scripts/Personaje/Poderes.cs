using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Poderes : MonoBehaviour {

	public bool poderCaracol=false;
	public bool poderBurbuja=false;
	public bool poderRayo=false;
	public float tiempo = 5;
	public SpriteRenderer burbujaPoder;

	private List<GameObject> suscriptoresCaracol = new List<GameObject>();

	public void suscribir(GameObject obj)
	{
		suscriptoresCaracol.Add (obj);
	}

	void avisarCaracolOn()
	{
		foreach (GameObject obj in suscriptoresCaracol)
		{
			if(obj != null)
			{
				obj.GetComponent<SuscriptorCaracol>().caracol = true;
			}
		}
	}

	void avisarCaracolOff()
	{
		foreach (GameObject obj in suscriptoresCaracol)
		{
			if(obj != null)
			{
				obj.GetComponent<SuscriptorCaracol>().caracol = false;
			}
		}
	}

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
		avisarCaracolOn();
		yield return new WaitForSeconds(tiempo);
		poderCaracol = false;
		avisarCaracolOff();
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
