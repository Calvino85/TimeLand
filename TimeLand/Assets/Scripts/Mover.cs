﻿using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {


	[HideInInspector]
	public bool facingRight = true;			// For determining which way the player is currently facing.
	[HideInInspector]
	public bool jump = false;				// Condition for whether the player should jump.
	
	
	public float moveForce = 365f;			// Amount of force added to move the player left and right.
	public float maxSpeed = 5f;				// The fastest the player can travel in the x axis.
	public AudioClip[] jumpClips;			// Array of clips for when the player jumps.
	public float jumpForce = 1000f;			// Amount of force added when the player jumps.
	public AudioClip[] taunts;				// Array of clips for when the player taunts.
	public float tauntProbability = 50f;	// Chance of a taunt happening.
	public float tauntDelay = 1f;			// Delay for when the taunt should happen.
	public float dir=0;
	public int vida=10;

	private int tauntIndex;					// The index of the taunts array indicating the most recent taunt.
	private Transform groundCheck;			// A position marking where to check if the player is grounded.
	private bool grounded = false;			// Whether or not the player is grounded.
	private Animator anim;					// Reference to the player's animator component.
	private float h;

	public bool poderCaracol=false;
	public bool poderBurbuja=false;
	public bool poderRayo=false;

	public string[] item=new string[30]; 
	public int numItem=0;
	public int puntoRetorno=0;

	void Awake()
	{
		// Setting up references.
		groundCheck = transform.Find("groundCheck");
		anim = GetComponent<Animator>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	void Update(){
		// The player is grounded if a linecast to the groundcheck position hits anything on the ground layer.
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));  

		// If the jump button is pressed and the player is grounded then the player should jump.
		if(Input.GetButtonDown("Jump") && grounded)
			jump = true;

		//Debug.Log(grounded);
	}
	void OnCollisionEnter2D(Collision2D coll) {
		if(coll.gameObject.tag == "Enemy" && poderBurbuja==true){
			vida--;
		}

		if(coll.gameObject.tag == "Reloj"){
			vida++;
			Destroy(coll.gameObject,.1f);
		}

		if(coll.gameObject.tag == "Poderes"){
			Debug.Log (coll.gameObject.name);
			Destroy(coll.gameObject,.1f);

			if(coll.gameObject.name == "Caracol"){
				poderCaracol=true;
			}

			if(coll.gameObject.name == "Burbuja"){
				poderBurbuja=true;
			}

			if(coll.gameObject.name == "Rayo"){
				poderRayo=true;
			}
		}

		if(coll.gameObject.tag == "Escalera"){

		}

		if(coll.gameObject.tag == "Item"){
			item[numItem]=coll.gameObject.name;
			Destroy(coll.gameObject,.1f);
			numItem++;
		}

		if(coll.gameObject.tag == "Base"){
			if(coll.gameObject.name == "Base1"){
				puntoRetorno=1;
			}

			if(coll.gameObject.name == "Base2"){
				puntoRetorno=2;
			}

			if(coll.gameObject.name == "Base3"){
				puntoRetorno=3;
			}
		}
	}
	void FixedUpdate ()
	{

		// Cache the horizontal input.
		h = Input.GetAxis("Horizontal");
		//float v = Input.GetAxis("Vertical");
		// The Speed animator parameter is set to the absolute value of the horizontal input.
		//anim.SetFloat("Speed", Mathf.Abs(h));

		if(h>0&&jump==false){
			anim.Play("CorreIZQ-DER");
			dir=1;
		}else{
			if(h<0&&jump==false){
				anim.Play("CorreDER-IZQ");
				dir=-1;
			}else{
				if(jump==false){
					anim.Play("Quieto");
					dir=1;
				}
			}
		}
		
		// If the player is changing direction (h has a different sign to velocity.x) or hasn't reached maxSpeed yet...
		if(h * GetComponent<Rigidbody2D>().velocity.x < maxSpeed)
			// ... add a force to the player.
			GetComponent<Rigidbody2D>().AddForce(Vector2.right * h * moveForce);
		
		// If the player's horizontal velocity is greater than the maxSpeed...
		if(Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) > maxSpeed)
			// ... set the player's velocity to the maxSpeed in the x axis.
			GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Sign(GetComponent<Rigidbody2D>().velocity.x) * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if(h==0)
			GetComponent<Rigidbody2D>().velocity = new Vector2(0f, GetComponent<Rigidbody2D>().velocity.y);
		
		// If the player should jump...
		if(jump){

			if(dir==1){
				// Set the Jump animator trigger parameter.
				anim.SetTrigger("Jump");
			}else{
				anim.SetTrigger("Jump2");
			}
						
			// Add a vertical force to the player.
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
			
			// Make sure the player can't jump again until the jump conditions from Update are satisfied.
			jump = false;
		}
	}
	
	
	void Flip ()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
