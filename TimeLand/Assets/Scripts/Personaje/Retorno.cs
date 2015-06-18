using UnityEngine;
using System.Collections;

public class Retorno : MonoBehaviour {

	public int puntoRetorno=0;
	public GameObject base0;
	public GameObject base1;
	public GameObject base2;
	public GameObject base3;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll) {
		Debug.Log("entro retorno");
		
		if(coll.gameObject.tag == "Base"){
			if(coll.gameObject.name == "Base1"){
				puntoRetorno=1;
			}
			
			if(coll.gameObject.name == "Base2"){
				puntoRetorno=2;
			}
			
			if(coll.gameObject.name == "Base3"){
				puntoRetorno=3;
			}
		}
	}

	public void irBase(){
		if (puntoRetorno == 0) {
			transform.position = base0.transform.position;
		} else {
			if (puntoRetorno == 1) {
				transform.position = base1.transform.position;
			} else {
				if (puntoRetorno == 2) {
					transform.position = base2.transform.position;
				}else{
					if (puntoRetorno == 3) {
						transform.position = base3.transform.position;
					}
				}
			}
		}
	}

}
