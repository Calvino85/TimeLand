using UnityEngine;
using System.Collections;

public class MoverArena : MonoBehaviour {

	public float[] positions;
	private int actualPosition;
	public bool invulnerable = false;
	public float tiempoInvulnerabilidad = 1f;


	void Start()
	{
		actualPosition = 0;
		this.gameObject.transform.localPosition = new Vector3 (this.transform.localPosition.x, positions[actualPosition], this.transform.localPosition.z);
	}

	void OnCollisionEnter2D(Collision2D coll) {	
		if(!invulnerable && actualPosition < positions.Length)
		{
			if (coll.gameObject.tag == "Player") {
				StartCoroutine(CambiarPosicion ());
			}
		}
	}

	IEnumerator CambiarPosicion()
	{
		invulnerable = true;
		actualPosition++;
		this.gameObject.transform.localPosition = new Vector3 (this.transform.localPosition.x, positions[actualPosition], this.transform.localPosition.z);
		yield return new WaitForSeconds(tiempoInvulnerabilidad);
		invulnerable = false;
	}

}
