using UnityEngine;
using System.Collections;

public class TocarEnemy : MonoBehaviour {

	public bool invulnerable = false;
	public float tiempoInvulnerabilidad = 1f;

	void OnCollisionStay2D(Collision2D coll) {
		if(!invulnerable) {
			if (coll.gameObject.tag == "EnemyPies" && GameObject.Find ("Protagonista").GetComponent<Poderes>().poderBurbuja == false) {
				if(coll.gameObject.transform.parent.gameObject.name == "Cucu") {
					StartCoroutine(QuitarVida (5));
				} else {
					StartCoroutine(QuitarVida (1));
				}
			}
		}
	}

	IEnumerator QuitarVida(int i)
	{
		invulnerable = true;
		GameObject.Find("Vida").GetComponent<Vida>().vida -= i;
		GameObject.Find("Vida").GetComponent<Vida>().revisarMuerte();
		yield return new WaitForSeconds(tiempoInvulnerabilidad);
		invulnerable = false;
	}
}
