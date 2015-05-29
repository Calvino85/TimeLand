using UnityEngine;
using System.Collections;

public class Vida : MonoBehaviour {

	public Sprite[] sprites; // Drag your first sprite here
	public Sprite sprite0; // Drag your first sprite here
	public Sprite sprite1; // Drag your first sprite here
	public Sprite sprite2; // Drag your second sprite here
	public Sprite sprite3; // Drag your second sprite here
	public Sprite sprite4; // Drag your second sprite here
	public Sprite sprite5; // Drag your second sprite here
	public Sprite sprite6; // Drag your second sprite here
	public Sprite sprite7; // Drag your second sprite here
	public Sprite sprite8; // Drag your second sprite here
	public Sprite sprite9; // Drag your second sprite here
	public Sprite sprite10; // Drag your second sprite here

	private SpriteRenderer spriteRenderer;

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

		int vida=GameObject.Find ("Protagonista").GetComponent<Mover>().vida;

		spriteRenderer.sprite = sprites[vida];

		/*
		//lenguage=GameObject.Find("PlaneO").GetComponent<lenguage>().l;
		if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
		{
			spriteRenderer.sprite = sprite2;
		}
		else
		{
			spriteRenderer.sprite = sprite1; // otherwise change it back to sprite1
		}*/
	}
}
