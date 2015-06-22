using UnityEngine;
using System.Collections;

public class MoverArenaRelojitos : MonoBehaviour {

	public Sprite[] sprites=new Sprite[6]; // Drag your first sprite here
	public Sprite[] spritesrelojitos=new Sprite[6]; // Drag your first sprite here
	public Sprite sprite1; // Drag your first sprite here
	public int numSprite=0;
	public bool play=false;
	
	
	private SpriteRenderer spriteRenderer;	
	private SpriteRenderer spriteRenderer2;
	private SpriteRenderer spriteRenderer3;
	private SpriteRenderer spriteRenderer4;
	// Use this for initialization
	void Start ()
	{
		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
		spriteRenderer2 = GameObject.Find("Relojito1").GetComponent<SpriteRenderer>(); 
		spriteRenderer3 = GameObject.Find("Relojito2").GetComponent<SpriteRenderer>(); 
		spriteRenderer4 = GameObject.Find("Relojito3").GetComponent<SpriteRenderer>(); 

		if (spriteRenderer.sprite == null) { // if the sprite on spriteRenderer is null then
				spriteRenderer.sprite = sprite1; // set the sprite to sprite1
				//spriteRenderer2.sprite = sprite1; // set the sprite to sprite1
		}
	}
	
	
	// Update is called once per frame
	void Update () {
		changeSprite ();
	}
	
	void changeSprite ()
	{
		spriteRenderer.sprite = sprites[numSprite];
		spriteRenderer2.sprite = spritesrelojitos[numSprite];
		spriteRenderer3.sprite = spritesrelojitos[numSprite];
		spriteRenderer4.sprite = spritesrelojitos[numSprite];
	}

	public void siguienteSprite(){
		numSprite++;

		if(numSprite==5&&play==false){		
			GameObject.Find("Relojero").GetComponent<MuerteRelojero>().animacionMuerteRelojero();			
		}

		if(numSprite>5){
			numSprite=5;
		}
	}
}
