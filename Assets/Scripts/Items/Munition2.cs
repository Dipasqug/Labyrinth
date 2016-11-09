using UnityEngine;
using System.Collections;

public class Munition2 : MonoBehaviour {
	
	private GameObject Waffe;

	// Use this for initialization
	void Start () {
		Waffe = GameObject.Find ("Fernkampf 2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider spieler) {
		if (spieler.gameObject.name == "Player") {
			Waffe.GetComponent<ShootBullet>().Munition = Waffe.GetComponent<ShootBullet>().maxMunition;
			Destroy (gameObject);
		}

	}
}
