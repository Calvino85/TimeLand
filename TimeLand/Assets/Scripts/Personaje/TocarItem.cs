using UnityEngine;
using System.Collections;

public class TocarItem : MonoBehaviour {

	public string[] item=new string[30]; 
	public int numItem=0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll) {	
		
		if(coll.gameObject.tag == "Item"){
			item[numItem]=coll.gameObject.name;
			numItem++;
			GameObject.Find ("Main Camera").GetComponent<MostrarIntentos>().mostrarItem(coll.gameObject.name);
			Destroy(coll.gameObject);
			VerificarFinEscenario();
		}
						
		if(coll.gameObject.tag == "Reloj"){

			if(GameObject.Find ("Vida").GetComponent<Vida>().vida <= 9){
				GameObject.Find ("Vida").GetComponent<Vida>().vida++;
			}
			
			Destroy(coll.gameObject);
		}
	}

	void VerificarFinEscenario()
	{
		if(Application.loadedLevelName == "Cronos")
		{
			if(numItem == 5)
			{
				Application.LoadLevel("OMEGA FINAL");
			}
		}
		if(Application.loadedLevelName == "OMEGA FINAL")
		{
			if(numItem == 3)
			{
				Application.LoadLevel("MUNDO PHI");
			}
		}
	}
}
