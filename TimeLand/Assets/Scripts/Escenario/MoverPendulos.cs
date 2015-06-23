using UnityEngine;
using System.Collections;

public class MoverPendulos : MonoBehaviour {

	public float posicionInicial;
	public float posicionFinal;
	private bool direccion;
	public float velocidad;
	private float posicionNueva;
	private SuscriptorCaracol suscriptor;
	public float cambiarVelocidad = 2f;

	// Use this for initialization
	void Start () {
		direccion = true;
		suscriptor = GetComponent<SuscriptorCaracol>();
	}
	
	// Update is called once per frame
	void Update () {

		float velocidadActual;
		
		if (suscriptor.caracol) {
			velocidadActual = velocidad / cambiarVelocidad;
		} else {
			velocidadActual = velocidad;
		}

		if (direccion) {
			this.transform.Rotate(new Vector3(0f, 0f, velocidadActual * Time.deltaTime));
			posicionNueva = this.transform.localRotation.eulerAngles.z;
			if(posicionNueva > posicionFinal) {
				direccion = false;
			}
		} else {
			this.transform.Rotate(new Vector3(0f, 0f, -1f * velocidadActual * Time.deltaTime));
			posicionNueva = this.transform.localRotation.eulerAngles.z;
			if(posicionNueva < posicionInicial) {
				direccion = true;
			}
		}
	
	}
}
