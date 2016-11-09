using UnityEngine;
using System.Collections;

public class CharacterMovement: MonoBehaviour {

	public float moveSpeed;
	public float currentMoveSpeed;
	public float diagonalModifier;

	private Vector3 moveInput;
	private Vector3 moveVelocity;
	
	private bool rechts;
	private bool links;
	private bool oben;
	private bool unten;

	private Rigidbody motor;
	private Transform drehen;

	// Use this for initialization
	void Start () {
		motor = GetComponent<Rigidbody>();
		drehen = GetComponent<Transform> ();

		rechts = false;
		links = false;
		oben = false;
		unten = false;
	}
	
	// Update is called once per frame
	void Update () {

		//Hier wird untersucht, ob der Spieler sich diagonal bewegt, indem der GetAxis Wert bei beiden auf 1 oder -1 steht
		if (Mathf.Abs (Input.GetAxisRaw("Vertical")) > 0.5f && Mathf.Abs (Input.GetAxisRaw("Horizontal")) > 0.5f) {
			currentMoveSpeed = moveSpeed * diagonalModifier;
		}
		else {
			currentMoveSpeed = moveSpeed;
			
		}

		moveInput = new Vector3(-Input.GetAxisRaw("Vertical"), 0f, Input.GetAxisRaw("Horizontal"));
		moveVelocity = moveInput * currentMoveSpeed;


	}

	void FixedUpdate() {
		motor.velocity = moveVelocity; 

		// Ab hier die Richtungsänderung des Characters
		if (Input.GetKey (KeyCode.D) && !rechts) {
			drehen.forward = new Vector3(-1f, 0f, 0f);
			rechts = true;
			links = false;
			oben = false;
			unten = false;
		}
		
		if (Input.GetKey (KeyCode.A) && !links) {
			drehen.forward = new Vector3(1f, 0f, 0f);
			links = true;
			rechts = false;
			oben = false;
			unten = false;
		}
		
		if (Input.GetKey (KeyCode.W) && !oben) {
			drehen.forward = new Vector3(0f, 0f, -1f);
			oben = true;
			links = false;
			rechts = false;
			unten = false;
		}
		
		if (Input.GetKey (KeyCode.S) && !unten) {
			drehen.forward = new Vector3(0f, 0f, 1f);
			unten = true;
			oben = false;
			links = false;
			rechts = false;
		}
	}
}