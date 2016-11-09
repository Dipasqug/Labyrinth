using UnityEngine;
using System.Collections;

public class DoubleSidedShadow : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		GetComponent<Renderer> ().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.TwoSided;
		Destroy (this);
	}
}
