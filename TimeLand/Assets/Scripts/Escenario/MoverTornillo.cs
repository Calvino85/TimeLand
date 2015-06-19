using UnityEngine;
using System.Collections;

public class MoverTornillo : MonoBehaviour {

	public float posicionInicial;
	public float posicionFinal;
	private bool direccion;
	public float velocidad;
	private float posicionNueva;
	private SuscriptorCaracol suscriptor;
	
	// Use this for initialization
	void Start () {
		direccion = true;
		suscriptor = GetComponent<SuscriptorCaracol>();
	}
	
	// Update is called once per frame
	void Update () {
		
		float velocidadActual;
		
		if (suscriptor.caracol) {
			velocidadActual = velocidad / 2f;
		} else {
			velocidadActual = velocidad;
		}
		
		if (direccion) {
			posicionNueva = this.transform.position.y + velocidadActual * Time.deltaTime;
			this.transform.position = new Vector3(this.transform.position.x, posicionNueva, this.transform.position.z);
			
			if(posicionNueva > posicionFinal) {
				direccion = false;
			}
		} else {
			posicionNueva = this.transform.position.y - velocidadActual * Time.deltaTime;
			this.transform.position = new Vector3(this.transform.position.x, posicionNueva, this.transform.position.z);
			
			if(posicionNueva < posicionInicial) {
				direccion = true;
			}
		}
		
	}
}
