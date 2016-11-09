using UnityEngine;
using System.Collections;

public class OldCharacterMovement : MonoBehaviour {
	
    public float speed = 10;

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
		 motor.velocity = new Vector3(1, 1, 1);
      	 float leftRight = Input.GetAxis("Horizontal");
       	 float upDown = Input.GetAxis("Vertical");
	
		 motor.velocity = new Vector3(-upDown, 0, leftRight) * speed;
	

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