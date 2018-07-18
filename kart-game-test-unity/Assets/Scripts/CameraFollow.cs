using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Class variables
	public Transform target; // target transform that the camera follows
	public Vector3 offset; // vector that determines where the camera will be relative to the target

	void Start() {
		
	}

	void LateUpdate () {
		
		transform.position = target.TransformPoint(offset); // compute position

		transform.LookAt (target); // compute rotation
	}
}
