using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	private Collider exitTrigger;
	

	// Use this for initialization
	void Start () {
		exitTrigger = gameObject.GetComponent<Collider> ();

		exitTrigger.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

//		if (GameObject.Find ("Boss").GetComponent<BossTrigger>().bossBesiegt) {
//			exitTrigger.enabled = true;
//		}

	}

	public void OpenDoor() {
		exitTrigger.enabled = true;
		
	}

	void OnTriggerEnter (Collider collider){
		Application.LoadLevel("Levelexit");
	}

}
