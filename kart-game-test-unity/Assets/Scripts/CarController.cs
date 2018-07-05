using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

	// Class variables

	public List<AxleInfo> axleInfos; // the information about each individual axle;
	public float maxMotorTorque; // maximum torque the motor can apply to the wheels
	public float maxSteeringAngle; // maximum steer angle the wheel can have

	// Fixed update method for controlling the car
	public void FixedUpdate () {
		float motor = maxMotorTorque * Input.GetAxis ("Vertical"); // gets input from vertical axis for acceleration
		float steering = maxSteeringAngle * Input.GetAxis ("Horizontal"); // gets input from horizontal axis for steering

		foreach (AxleInfo axleInfo in axleInfos) {
			if (axleInfo.steering) {
				axleInfo.leftWheel.steerAngle = steering; // change the state of the wheels if the car is steering
				axleInfo.rightWheel.steerAngle = steering;
			}
			if (axleInfo.motor) {
				axleInfo.leftWheel.motorTorque = motor; // change the state of the wheels if they are connected to a motor
				axleInfo.rightWheel.motorTorque = motor;
			}
		}
	}
}

// Additional class that contains information about the axles
[System.Serializable]
public class AxleInfo {
	public WheelCollider leftWheel; // left wheel attached to axle
	public WheelCollider rightWheel; // right wheel attached to axle
	public bool motor; // is the wheel attached to a motor?
	public bool steering; // does this wheel apply steer angle?
}
