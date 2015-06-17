using UnityEngine;
using System.Collections;

public class MoverTuercas : MonoBehaviour {

	public bool moverX;
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
			if (moverX) {
				posicionNueva = this.transform.position.x + velocidad * Time.deltaTime;
				this.transform.position = new Vector3(posicionNueva, this.transform.position.y, this.transform.position.z);

			} else {
				posicionNueva = this.transform.position.y + velocidad * Time.deltaTime;
				this.transform.position = new Vector3(this.transform.position.x, posicionNueva, this.transform.position.z);
			}

			if(posicionNueva > posicionFinal) {
				direccion = false;
			}
		} else {
			if (moverX) {
				posicionNueva = this.transform.position.x - velocidad * Time.deltaTime;
				this.transform.position = new Vector3(posicionNueva, this.transform.position.y, this.transform.position.z);
				
			} else {
				posicionNueva = this.transform.position.y - velocidad * Time.deltaTime;
				this.transform.position = new Vector3(this.transform.position.x, posicionNueva, this.transform.position.z);
			}
			
			if(posicionNueva < posicionInicial) {
				direccion = true;
			}
		}
	
	}
}
