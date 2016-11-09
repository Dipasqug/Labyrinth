using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {
	
	public float maxMunition;
	public float Munition;

	public float Burst;
	private float BulletCd = 0.11f;

	public float firerate = 0.5f;
	private float timer = 0;

	public float BulletSpeed;
	public float bulletRange;

	public float Piercing;
	public int WeaponDamage;

	public GameObject bulletPrefab;
	private Transform spawn;
	
	// Use this for initialization
	void Start () {
		spawn = GetComponent<Transform> ();
		timer = firerate;
		Munition = maxMunition;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (Input.GetKey (KeyCode.Space) && timer >= firerate) {

			if (Munition >= Burst) {
				timer = 0;
				StartCoroutine (CreateBullet ());
				Munition -= Burst;
			}

			else {
//				print ("Keine Munition!");
			}
		}

	}

	// Hier wird die Kugel abgefeuert solange, wie i den Wert von Burst erreicht
	public IEnumerator CreateBullet(){
		for (int i = 0; i < Burst; i++) {
				
				Instantiate (bulletPrefab, spawn.position, spawn.rotation);
				yield return new WaitForSeconds(BulletCd);

		}
	}
}
