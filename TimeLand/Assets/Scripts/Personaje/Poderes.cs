using UnityEngine;
using System.Collections;

public class Poderes : MonoBehaviour {

	public bool poderCaracol=false;
	public bool poderBurbuja=false;
	public bool poderRayo=false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {

		if(coll.gameObject.tag == "Poderes"){
			//Debug.Log (coll.gameObject.name);
			Destroy(coll.gameObject,.1f);
			
			if(coll.gameObject.name == "Caracol"){
				poderCaracol=true;
			}
			
			if(coll.gameObject.name == "Burbuja"){
				poderBurbuja=true;
			}
			
			if(coll.gameObject.name == "Rayo"){
				poderRayo=true;
			}
		}
	}
}
