using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

	public GameObject padre;
	public int HP = 1;					// How many times the enemy can be hit before it dies.

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log (coll.gameObject.tag);

		if (coll.gameObject.tag == "Player") {
			//coll.gameObject.SendMessage("ApplyDamage", 10);
			Debug.Log ("Dio cabeza");

			//GameObject.Find("Protagonista").GetComponent<Vida>().vida++;

			HP--;
		}
		 
		if(HP<1){
			Destroy(padre,.1f);
		}
	}
}