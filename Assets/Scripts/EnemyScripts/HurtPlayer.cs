using UnityEngine;
using System.Collections;

public class HurtPlayer : MonoBehaviour {

	public int DamageToGive;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Hier gibt der Gegner dem Spieler schaden bei Kontakt
	void OnCollisionEnter (Collision player){
		if (player.gameObject.name == "Player") {

			player.gameObject.GetComponent<LebenSpieler>().HurtPlayer(DamageToGive);
		}
	}
}
