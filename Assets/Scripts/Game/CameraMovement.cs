using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	
	public float x;
	public float y;
	public float z;

	private Transform spieler;

	// Use this for initialization
	void Start () {
		spieler = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = spieler.position + new Vector3 (x, y, z);
	}
}
