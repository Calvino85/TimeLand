using UnityEngine;
using System.Collections;

public class TocarEnemy : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "EnemyCabeza") {
			//Generar evento de reinicio
			Debug.Log("Evento de Cabeza");
		}
		if (coll.gameObject.tag == "EnemyPies") {
			//Generar evento de reinicio
			Debug.Log("Evento de Pies");
		}
	}
}
