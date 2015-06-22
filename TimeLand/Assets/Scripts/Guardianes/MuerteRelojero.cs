using UnityEngine;
using System.Collections;

public class MuerteRelojero : MonoBehaviour {

	public Sprite sprite1; // Drag your first sprite here
	private SpriteRenderer spriteRenderer;	
	public bool play=false;
	
	// Use this for initialization
	void Start ()
	{
		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
		if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
			spriteRenderer.sprite = sprite1; // set the sprite to sprite1
	}
	
	
	// Update is called once per frame
	void Update () {
		changeSprite ();
	}
	
	void changeSprite ()
	{
		if(GameObject.Find ("Arena Relojero").GetComponent<MoverArena>()==true){
			spriteRenderer.sprite = sprite1;
		}
	}

	public void animacionMuerteRelojero(){
		
		if(play==false){		
			Animator animator=GameObject.Find("Relojero").GetComponent<Animator>();			
			animator.Play("RelojeroRoto");
			play=true;
			GameObject.Find("Cucu").GetComponent<MostrarCucu>().mostrarCucu();
		}
	}
}
