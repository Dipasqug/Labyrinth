using UnityEngine;
using System.Collections;

public class Invisible : MonoBehaviour {

	private Renderer rendern;

	// Use this for initialization
	void Start () {
		rendern = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		rendern.enabled = false;
	}
}
