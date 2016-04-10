using UnityEngine;
using System.Collections;

public class CanvasScalar : MonoBehaviour {
	public Canvas ui;
	// Use this for initialization
	void Start () {
		Camera camera = GetComponentsInChildren<Camera> () [0];
		ui.transform.parent = camera.transform;
	}
}
