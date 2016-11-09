using UnityEngine;
using System.Collections;

public class BossTrigger : MonoBehaviour {
	

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDestroy() {
		GameObject.Find ("ExitTrigger").GetComponent<Exit>().OpenDoor();
//		print ("Der Boss wurde besiegt! Das Tor wurde geöffnet.");
	}

}
