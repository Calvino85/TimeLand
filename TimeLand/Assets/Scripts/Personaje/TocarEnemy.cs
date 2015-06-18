using UnityEngine;
using System.Collections;

public class TocarEnemy : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "EnemyCabeza") {
			//Generar evento de reinicio
			Debug.Log("Evento de Cabeza");
		}
		if (coll.gameObject.tag == "EnemyPies" /*&& GameObject.Find ("Protagonista").GetComponent<Poderes>().poderRayo==false*/) {
			//Generar evento de reinicio
			Debug.Log("Evento de Pies");

			GameObject.Find ("Vida").GetComponent<Vida>().vida--;

			//GetComponent<Rigidbody2D>().AddForce(Vector2.right * -h * 4000);
											
			GameObject.Find ("Protagonista").GetComponent<Vida>().revisarMuerte();
		}
	}
}
