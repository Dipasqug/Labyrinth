 using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	public float coolDown = 0.5f;
	private float timer = 0;

	private bool attacking;

	private Collider nahkampf;

	// Use this for initialization
	void Start () {
		nahkampf = gameObject.GetComponent<Collider> ();
		nahkampf.enabled = false;
		attacking = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && !attacking) {
		    nahkampf.enabled = true;
			attacking = true;
			timer = coolDown;
        }

		if (attacking) {
      		  if (timer > 0) {
			  timer -= Time.deltaTime;
			}

		else {
			  attacking = false;
              nahkampf.enabled = false;
			}
		}
	}
}
