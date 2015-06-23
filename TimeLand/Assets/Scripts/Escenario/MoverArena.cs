using UnityEngine;
using System.Collections;

public class MoverArena : MonoBehaviour {

	public float[] posiciones;
	public Sprite[] arena;
	public SpriteRenderer renderer;
	private int posicionActual;
	public bool invulnerable = false;
	public float tiempoInvulnerabilidad = 1f;


	void Start()
	{
		posicionActual = 0;
		this.gameObject.transform.localPosition = new Vector3 (this.transform.localPosition.x, posiciones[posicionActual], this.transform.localPosition.z);
		renderer.sprite = arena[posicionActual];
	}

	void OnCollisionEnter2D(Collision2D coll) {	
		if(!invulnerable && posicionActual < posiciones.Length)
		{
			if (coll.gameObject.tag == "Player") {
				StartCoroutine(CambiarPosicion ());
			}
		}
	}

	IEnumerator CambiarPosicion()
	{
		invulnerable = true;
		posicionActual++;
		this.gameObject.transform.localPosition = new Vector3 (this.transform.localPosition.x, posiciones[posicionActual], this.transform.localPosition.z);
		renderer.sprite = arena[posicionActual];
		yield return new WaitForSeconds(tiempoInvulnerabilidad);
		invulnerable = false;
	}

}
