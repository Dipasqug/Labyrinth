using UnityEngine;
using System.Collections;

public class LebenGegner : MonoBehaviour {

	public float maxLeben;
	public float leben;

	// Use this for initialization
	void Start () {
		leben = maxLeben;
	}
	
	// Update is called once per frame
	void Update () {
		if (leben <= 0) {
			Destroy (gameObject);
		}
	}

	public void HurtEnemy (int WeaponDamage) { 
		if (leben > 0) {
			leben -= WeaponDamage;
		} 
	}

}
