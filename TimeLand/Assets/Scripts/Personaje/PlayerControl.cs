using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
	[HideInInspector]
	public bool facingRight = true;			// For determining which way the player is currently facing.
	[HideInInspector]
	public bool jump = false;				// Condition for whether the player should jump.


	public float moveForce = 365f;
	public float moveUpDownForce = 365f;
	public float maxSpeed = 5f;
	public float jumpForce = 1000f;
	public float minVelocity = 0.5f;

	private Transform groundCheck;			// A position marking where to check if the player is grounded.
	private bool grounded = false;			// Whether or not the player is grounded.
	private Animator anim;					// Reference to the player's animator component.
	private bool doubleJump = false;
	private bool stairs = false;

	void Awake()
	{
		// Setting up references.
		groundCheck = transform.Find("groundCheck");
		anim = GetComponent<Animator>();
	}


	void Update()
	{
		// The player is grounded if a linecast to the groundcheck position hits anything on the ground layer.
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));  
		if(grounded)
		{
			doubleJump = true;
		}

		// If the jump button is pressed and the player is grounded then the player should jump.
		if(Input.GetButtonDown("Jump") && grounded)
		{
			jump = true;
		}
		else if (Input.GetButtonDown("Jump") && doubleJump)
		{
			jump = true;
			doubleJump = false;
		}
	}


	void FixedUpdate ()
	{
		// Cache the horizontal input.
		float h = Input.GetAxis("Horizontal");

		if(h > 0)
		{
			facingRight = true;
		} else if(h < 0)
		{
			facingRight = false;
		}

		// If the player is changing direction (h has a different sign to velocity.x) or hasn't reached maxSpeed yet...
		if(h * rigidbody2D.velocity.x < maxSpeed)
			// ... add a force to the player.
			rigidbody2D.AddForce(Vector2.right * h * moveForce);

		// If the player's horizontal velocity is greater than the maxSpeed...
		if(Mathf.Abs(rigidbody2D.velocity.x) > maxSpeed)
			// ... set the player's velocity to the maxSpeed in the x axis.
			rigidbody2D.velocity = new Vector2(Mathf.Sign(rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);

		float v = Input.GetAxis("Vertical");

		if(v * rigidbody2D.velocity.y < maxSpeed && stairs)
			// ... add a force to the player.
			rigidbody2D.AddForce(Vector2.up * v * moveUpDownForce);
		
		// If the player's horizontal velocity is greater than the maxSpeed...
		if(Mathf.Abs(rigidbody2D.velocity.y) > maxSpeed && stairs)
			// ... set the player's velocity to the maxSpeed in the x axis.
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, Mathf.Sign(rigidbody2D.velocity.y) * maxSpeed);

		if(!grounded && !stairs && facingRight)
		{
			anim.ResetTrigger("Quieto");
			anim.ResetTrigger("RayoCorreDER-IZQ");
			anim.ResetTrigger("CorreDER-IZQ");
			anim.ResetTrigger("RayoSaltoDER-IZQ");
			anim.ResetTrigger("SaltoDER-IZQ");
			anim.ResetTrigger("RayoCorreIZQ-DER");
			anim.ResetTrigger("CorreIZQ-DER");
			anim.ResetTrigger("RayoSaltoIZQ-DER");
			anim.SetTrigger("SaltoIZQ-DER");
			anim.ResetTrigger("BenitoSube");
			anim.ResetTrigger("RayoSube");
		} else if(!grounded && !stairs && !facingRight)
		{
			anim.ResetTrigger("Quieto");
			anim.ResetTrigger("RayoCorreDER-IZQ");
			anim.ResetTrigger("CorreDER-IZQ");
			anim.ResetTrigger("RayoSaltoDER-IZQ");
			anim.SetTrigger("SaltoDER-IZQ");
			anim.ResetTrigger("RayoCorreIZQ-DER");
			anim.ResetTrigger("CorreIZQ-DER");
			anim.ResetTrigger("RayoSaltoIZQ-DER");
			anim.ResetTrigger("SaltoIZQ-DER");
			anim.ResetTrigger("BenitoSube");
			anim.ResetTrigger("RayoSube");
		} else if(grounded && facingRight && Mathf.Abs(rigidbody2D.velocity.x) > minVelocity)
		{
			anim.ResetTrigger("Quieto");
			anim.ResetTrigger("RayoCorreDER-IZQ");
			anim.ResetTrigger("CorreDER-IZQ");
			anim.ResetTrigger("RayoSaltoDER-IZQ");
			anim.ResetTrigger("SaltoDER-IZQ");
			anim.ResetTrigger("RayoCorreIZQ-DER");
			anim.SetTrigger("CorreIZQ-DER");
			anim.ResetTrigger("RayoSaltoIZQ-DER");
			anim.ResetTrigger("SaltoIZQ-DER");
			anim.ResetTrigger("BenitoSube");
			anim.ResetTrigger("RayoSube");
		} else if(grounded && !facingRight && Mathf.Abs(rigidbody2D.velocity.x) > minVelocity)
		{
			anim.ResetTrigger("Quieto");
			anim.ResetTrigger("RayoCorreDER-IZQ");
			anim.SetTrigger("CorreDER-IZQ");
			anim.ResetTrigger("RayoSaltoDER-IZQ");
			anim.ResetTrigger("SaltoDER-IZQ");
			anim.ResetTrigger("RayoCorreIZQ-DER");
			anim.ResetTrigger("CorreIZQ-DER");
			anim.ResetTrigger("RayoSaltoIZQ-DER");
			anim.ResetTrigger("SaltoIZQ-DER");
			anim.ResetTrigger("BenitoSube");
			anim.ResetTrigger("RayoSube");
		} else if(stairs && Mathf.Abs(rigidbody2D.velocity.y) > minVelocity)
		{
			anim.ResetTrigger("Quieto");
			anim.ResetTrigger("RayoCorreDER-IZQ");
			anim.ResetTrigger("CorreDER-IZQ");
			anim.ResetTrigger("RayoSaltoDER-IZQ");
			anim.ResetTrigger("SaltoDER-IZQ");
			anim.ResetTrigger("RayoCorreIZQ-DER");
			anim.ResetTrigger("CorreIZQ-DER");
			anim.ResetTrigger("RayoSaltoIZQ-DER");
			anim.ResetTrigger("SaltoIZQ-DER");
			anim.SetTrigger("BenitoSube");
			anim.ResetTrigger("RayoSube");
		} else
		{
			anim.SetTrigger("Quieto");
			anim.ResetTrigger("RayoCorreDER-IZQ");
			anim.ResetTrigger("CorreDER-IZQ");
			anim.ResetTrigger("RayoSaltoDER-IZQ");
			anim.ResetTrigger("SaltoDER-IZQ");
			anim.ResetTrigger("RayoCorreIZQ-DER");
			anim.ResetTrigger("CorreIZQ-DER");
			anim.ResetTrigger("RayoSaltoIZQ-DER");
			anim.ResetTrigger("SaltoIZQ-DER");
			anim.ResetTrigger("BenitoSube");
			anim.ResetTrigger("RayoSube");
		}

		// If the player should jump...
		if(jump)
		{
			// Set the Jump animator trigger parameter.
			//anim.SetTrigger("Jump");

			// Add a vertical force to the player.
			rigidbody2D.AddForce(new Vector2(0f, jumpForce));

			// Make sure the player can't jump again until the jump conditions from Update are satisfied.
			jump = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Escalera")
		{
			rigidbody2D.gravityScale = 0f;
			stairs = true;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if(other.gameObject.tag == "Escalera")
		{
			rigidbody2D.gravityScale = 1f;
			stairs = false;
		}
	}
}
