using UnityEngine;
using System.Collections;

public class MoverPuerta : MonoBehaviour {

	private bool mover = false;
	public float posicionInicial;
	public float posicionFinal;
	public float velocidad;
	private float posicionNueva;
	private SuscriptorCaracol suscriptor;

	void OnCollisionEnter2D(Collision2D coll) {	
		
		if(coll.gameObject.tag == "Player"){
			if(coll.gameObject.GetComponent<TocarItem>().numItem == 1){
				mover = true;
			}
		}
	}

	// Use this for initialization
	void Start () {
		suscriptor = GetComponent<SuscriptorCaracol>();
	}

	// Update is called once per frame
	void Update () {
		
		if (mover) {
			float velocidadActual;
			
			if (suscriptor.caracol) {
				velocidadActual = velocidad / 2f;
			} else {
				velocidadActual = velocidad;
			}
			
			posicionNueva = this.transform.position.y + velocidadActual * Time.deltaTime;
			this.transform.position = new Vector3(this.transform.position.x, posicionNueva, this.transform.position.z);
			
			if(posicionNueva > posicionFinal) {
				mover = false;
			}
		}
	}
}
