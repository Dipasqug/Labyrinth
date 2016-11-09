using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	private float distance;
	private float leben;

	private Rigidbody motor;
	private GameObject Spieler;
	private GameObject Waffe;

	// Use this for initialization
	private void Start () {
		Waffe = GameObject.FindGameObjectWithTag ("Weapon");
		Spieler = GameObject.Find ("Player");

		motor = GetComponent<Rigidbody> ();
		motor.velocity = transform.forward * Waffe.GetComponent<ShootBullet>().BulletSpeed;

		leben = Waffe.GetComponent<ShootBullet>().Piercing;
	}

	// Update is called once per frame
	private void Update () {
		distance = Vector3.Distance (Spieler.GetComponent<Transform>().position, transform.position);

		if (distance >= Waffe.GetComponent<ShootBullet>().bulletRange) {
			Destroy (gameObject);
		}

		if (leben <= 0) {
			Destroy (gameObject);
		}
	}
	

	private void OnTriggerEnter(Collider other){
			leben -= 1;
		
		if (other.gameObject.tag == "Enemy") {
			other.gameObject.GetComponent<LebenGegner>().HurtEnemy(Waffe.GetComponent<ShootBullet>().WeaponDamage);
		}

		if (other.gameObject.tag != "Enemy") {
			Destroy (gameObject);
		}
	}

}
