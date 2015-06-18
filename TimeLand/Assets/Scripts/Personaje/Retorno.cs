using UnityEngine;
using System.Collections;

public class Retorno : MonoBehaviour {

	public int puntoRetorno=0;
	public GameObject base0;
	public GameObject base1;
	public GameObject base2;
	public GameObject base3;

	void Awake()
	{
		base0 = GameObject.Find ("Base0");
		base1 = GameObject.Find ("Base1");
		base2 = GameObject.Find ("Base2");
		base3 = GameObject.Find ("Base3");
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if(coll.gameObject.tag == "Base"){
			if(coll.gameObject.name == "Base0" && puntoRetorno <= 0){
				puntoRetorno=0;
			}

			if(coll.gameObject.name == "Base1" && puntoRetorno < 1){
				puntoRetorno=1;
			}
			
			if(coll.gameObject.name == "Base2" && puntoRetorno < 2){
				puntoRetorno=2;
			}
			
			if(coll.gameObject.name == "Base3" && puntoRetorno < 3){
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
