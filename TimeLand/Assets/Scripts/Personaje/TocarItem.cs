using UnityEngine;
using System.Collections;

public class TocarItem : MonoBehaviour {

	public string[] item=new string[30]; 
	public int numItem=0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {	
		
		if(coll.gameObject.tag == "Item"){
			item[numItem]=coll.gameObject.name;
			Destroy(coll.gameObject,.1f);
			numItem++;
		}
						
		if(coll.gameObject.tag == "Reloj"){
			GameObject.Find ("Vida").GetComponent<Vida>().vida++;
			
			if(GameObject.Find ("Vida").GetComponent<Vida>().vida > 10){
				GameObject.Find ("Vida").GetComponent<Vida>().vida=10;
			}
			
			Destroy(coll.gameObject,.1f);
		}
	}
}
