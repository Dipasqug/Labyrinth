using UnityEngine;
using System.Collections;

public class SpeedUp : MonoBehaviour {
	
	private GameObject Spieler;

	// Use this for initialization
	void Start () {
		Spieler = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider spieler) {
		if (spieler.gameObject.name == "Player") {
			Spieler.GetComponent<CharacterMovement>().moveSpeed += 2;
			Destroy (gameObject);
		}

	}
}
