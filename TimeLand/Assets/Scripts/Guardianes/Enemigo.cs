using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

	public GameObject padre;
	public int HP = 1;					// How many times the enemy can be hit before it dies.

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			HP--;
		}
		 
		if(HP < 1){
			Destroy(padre);
		}
	}
}