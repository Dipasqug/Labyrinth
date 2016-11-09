using UnityEngine;
using System.Collections;

public class HurtEnemy : MonoBehaviour {

	public int WeaponDamage;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	//Hier attackiert der Spieler ein mit "Enemy" getagtes Objekt
	void OnTriggerEnter (Collider hit) {
		if (hit.gameObject.tag == "Enemy") {

			hit.gameObject.GetComponent<LebenGegner>().HurtEnemy(WeaponDamage);
		}
	}

}
