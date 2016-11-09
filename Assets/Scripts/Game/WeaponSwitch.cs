using UnityEngine;
using System.Collections;

public class WeaponSwitch : MonoBehaviour {

	public GameObject waffe1;
	public GameObject waffe2;
	public GameObject waffe3;
	public GameObject waffe4;
	public GameObject waffe5;

	// Use this for initialization
	void Start () {
		waffe1 = GameObject.Find ("Nahkampf 1");
		waffe2 = GameObject.Find ("Nahkampf 2");
		waffe3 = GameObject.Find ("Fernkampf 1");
		waffe4 = GameObject.Find ("Fernkampf 2");
		waffe5 = GameObject.Find ("Wurfgeschoss");

		waffe1.SetActive (true);
		waffe2.SetActive (false);
		waffe3.SetActive (false);
		waffe4.SetActive (false);
		waffe5.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			waffe1.SetActive (true);
			waffe2.SetActive (false);
			waffe3.SetActive (false);
			waffe4.SetActive (false);
			waffe5.SetActive (false);
		}

		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			waffe1.SetActive (false);
			waffe2.SetActive (true);
			waffe3.SetActive (false);
			waffe4.SetActive (false);
			waffe5.SetActive (false);
		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			waffe1.SetActive (false);
			waffe2.SetActive (false);
			waffe3.SetActive (true);
			waffe4.SetActive (false);
			waffe5.SetActive (false);
		}

		if (Input.GetKeyDown (KeyCode.Alpha4)) {
			waffe1.SetActive (false);
			waffe2.SetActive (false);
			waffe3.SetActive (false);
			waffe4.SetActive (true);
			waffe5.SetActive (false);
		}

		if (Input.GetKeyDown (KeyCode.Alpha5)) {
			waffe1.SetActive (false);
			waffe2.SetActive (false);
			waffe3.SetActive (false);
			waffe4.SetActive (false);
			waffe5.SetActive (true);
		}
	}
}
