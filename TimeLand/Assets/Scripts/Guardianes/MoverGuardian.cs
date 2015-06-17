using UnityEngine;
using System.Collections;

public class MoverGuardian : MonoBehaviour {

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

			posicionNueva = this.transform.position.x + velocidad * Time.deltaTime;
			this.transform.position = new Vector3(posicionNueva, this.transform.position.y, this.transform.position.z);
			
			if(posicionNueva > posicionFinal) {
				direccion = false;
			}
		} else {
			posicionNueva = this.transform.position.x - velocidad * Time.deltaTime;
			this.transform.position = new Vector3(posicionNueva, this.transform.position.y, this.transform.position.z);
			
			if(posicionNueva < posicionInicial) {
				direccion = true;
			}
		}
		
	}
}
