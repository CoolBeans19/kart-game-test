using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStabilize : MonoBehaviour {

	public Transform target; // target that the camera is following

	void Update () {
		transform.eulerAngles = new Vector3 (0f, target.eulerAngles.y, 0f); // only follow the y rotation of the car
	}
}
