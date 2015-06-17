using UnityEngine;
using System.Collections;

public class MoverRuedas : MonoBehaviour {

	public bool direccion;
	public float velocidad;
	public GameObject tornillo1;
	public GameObject tornillo2;
	public GameObject tornillo3;
		
	// Update is called once per frame
	void Update () {

		if (direccion) {
			this.transform.Rotate(new Vector3(0f, 0f, velocidad * Time.deltaTime));
			tornillo1.transform.Rotate(new Vector3(0f, 0f, -1f * velocidad * Time.deltaTime));
			tornillo2.transform.Rotate(new Vector3(0f, 0f, -1f * velocidad * Time.deltaTime));
			tornillo3.transform.Rotate(new Vector3(0f, 0f, -1f * velocidad * Time.deltaTime));
		} else {
			this.transform.Rotate(new Vector3(0f, 0f, -1f * velocidad * Time.deltaTime));
			tornillo1.transform.Rotate(new Vector3(0f, 0f, velocidad * Time.deltaTime));
			tornillo2.transform.Rotate(new Vector3(0f, 0f, velocidad * Time.deltaTime));
			tornillo3.transform.Rotate(new Vector3(0f, 0f, velocidad * Time.deltaTime));
		}
		
	}
}
