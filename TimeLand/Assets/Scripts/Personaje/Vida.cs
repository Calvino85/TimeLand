﻿using UnityEngine;
using System.Collections;

public class Vida : MonoBehaviour {

	public Sprite[] sprites; // Drag your first sprite here
	public Sprite sprite1; // Drag your first sprite here


	private SpriteRenderer spriteRenderer;

	public int vida=10;
	public int intentos=3;


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
		if(vida <= 0){
			spriteRenderer.sprite = sprites[10];
		}
		else{
			spriteRenderer.sprite = sprites[10-vida];
		}

	}


	public void revisarMuerte() 
	{
		if(vida<=0){
			GameObject.Find ("Protagonista").GetComponent<Retorno>().irBase();
			intentos--;
			vida = 10;
		}

		if(intentos==0){
			Application.LoadLevel(Application.loadedLevelName);
		}
	}
}
