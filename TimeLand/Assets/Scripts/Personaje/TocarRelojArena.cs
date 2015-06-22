using UnityEngine;
using System.Collections;

public class TocarRelojArena : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {	
		//Debug.Log (coll.gameObject.tag);
		if(coll.gameObject.tag == "Player"){
			GameObject.Find ("Arena Relojero").GetComponent<MoverArenaRelojitos>().siguienteSprite();
		}
	}
}
