using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MostrarCucu : MonoBehaviour {

	public GameObject cucu;
	
	public void mostrarCucu(){
		if(GameObject.Find ("Relojero").GetComponent<MuerteRelojero>().play==true){
			cucu.GetComponent<SpriteRenderer>().enabled = true;
			cucu.GetComponentsInChildren<CircleCollider2D>()[0].enabled = true;
			cucu.GetComponentsInChildren<PolygonCollider2D>()[0].enabled = true;
		}
	}
}
