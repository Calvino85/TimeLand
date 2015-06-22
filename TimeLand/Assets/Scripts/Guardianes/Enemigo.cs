using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

	public GameObject padre;
	public int HP = 1;					// How many times the enemy can be hit before it dies.
	public bool invulnerable = false;
	public float tiempoInvulnerabilidad = 1f;

	void OnCollisionEnter2D(Collision2D coll) {
		if(!invulnerable)
		{
			if (coll.gameObject.tag == "Player") {
				StartCoroutine(QuitarVida ());
			}

		}
	}

	IEnumerator QuitarVida()
	{
		invulnerable = true;
		HP--;
		revisarMuerte ();
		yield return new WaitForSeconds(tiempoInvulnerabilidad);
		invulnerable = false;
	}

	void revisarMuerte()
	{

		if(HP < 1){
			if(padre.name=="Cucu"){
				Application.LoadLevel("Cronos");
			}
			Destroy(padre);
		}
	}
}