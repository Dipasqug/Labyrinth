using UnityEngine;
using System.Collections;

public class LebenSpieler : MonoBehaviour {

	public float maxLeben;
	public float leben;

	private float coolDown = 1.5f;
	private float timer;

	private bool immune;
	
	// Use this for initialization
	void Start () {
		leben = maxLeben;
		immune = false;
	}
	
	// Update is called once per frame
	void Update () {

		//Hier wird der Immune Status runtergezählt
		if (immune) {
			if (timer > 0){
				timer -= Time.deltaTime;
			}
			
			else {
				immune = false;
			}
		}

		if (leben <= 0) {
			Destroy (gameObject);
			Application.LoadLevel("Levelexit");
		}
	}


	public void HurtPlayer(int DamageToGive) {
		if (!immune) {
			leben -= DamageToGive;
			timer = coolDown;
			immune = true;
		}
	}
}
