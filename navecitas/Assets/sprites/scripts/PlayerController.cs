using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 3f;
	public float maxSpeed = 5f;
	public float jumpPower = 6.5f;
	private Rigidbody2D rigidbody2D;
	private bool jump;

	// Use this for initialization
	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("w")) {
			jump = true;
			
		}
		if(Input.GetKeyDown(KeyCode.Space)) {
			rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
		}
	}

	void FixedUpdate() {
		float h = Input.GetAxis("Horizontal");

		rigidbody2D.AddForce(Vector2.right * speed * h);

		if(rigidbody2D.velocity.x > maxSpeed) {
			rigidbody2D.velocity = new Vector2(maxSpeed, rigidbody2D.velocity.y);
		}

		if(rigidbody2D.velocity.x < -maxSpeed) {
			rigidbody2D.velocity = new Vector2(-maxSpeed, rigidbody2D.velocity.y);
		}

		if(jump) {
			rigidbody2D.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
			jump = false;
		}

		Debug.Log(rigidbody2D.velocity.x);
	}

	
}
