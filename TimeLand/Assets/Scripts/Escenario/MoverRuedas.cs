using UnityEngine;
using System.Collections;

public class MoverRuedas : MonoBehaviour {

	public bool direccion;
	public float velocidad;
	public GameObject tornillo1;
	public GameObject tornillo2;
	public GameObject tornillo3;
	private SuscriptorCaracol suscriptor;
	public float cambiarVelocidad = 2f;

	void Start() {
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
			tornillo1.transform.Rotate(new Vector3(0f, 0f, -1f * velocidadActual * Time.deltaTime));
			tornillo2.transform.Rotate(new Vector3(0f, 0f, -1f * velocidadActual * Time.deltaTime));
			tornillo3.transform.Rotate(new Vector3(0f, 0f, -1f * velocidadActual * Time.deltaTime));
		} else {
			this.transform.Rotate(new Vector3(0f, 0f, -1f * velocidadActual * Time.deltaTime));
			tornillo1.transform.Rotate(new Vector3(0f, 0f, velocidadActual * Time.deltaTime));
			tornillo2.transform.Rotate(new Vector3(0f, 0f, velocidadActual * Time.deltaTime));
			tornillo3.transform.Rotate(new Vector3(0f, 0f, velocidadActual * Time.deltaTime));
		}
		
	}
}
