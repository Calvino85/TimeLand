using UnityEngine;
using System.Collections;

public class MoverPendulos : MonoBehaviour {

	public float posicionInicial;
	public float posicionFinal;
	private bool direccion;
	public float velocidad;
	private float posicionNueva;

	// Use this for initialization
	void Start () {

		direccion = true;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (direccion) {
			this.transform.Rotate(new Vector3(0f, 0f, velocidad * Time.deltaTime));
			posicionNueva = this.transform.localRotation.eulerAngles.z;
			if(posicionNueva > posicionFinal) {
				direccion = false;
			}
		} else {
			this.transform.Rotate(new Vector3(0f, 0f, -1f * velocidad * Time.deltaTime));
			posicionNueva = this.transform.localRotation.eulerAngles.z;
			if(posicionNueva < posicionInicial) {
				direccion = true;
			}
		}
	
	}
}
