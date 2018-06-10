using UnityEngine;
using System.Collections;

public class IncreaseTyreSpeed : MonoBehaviour {
	WheelJoint2D wheel;
	JointMotor2D motor;

	void Start () {
		wheel = GameObject.Find ("carbody").GetComponent<WheelJoint2D> ();
		motor = wheel.motor;
	
	}


	void Update () {
			
	}

	void OnCollisionEnter2D(Collision2D obj){
		if (obj.gameObject.tag == "Boost") {
			wheel.useMotor = true;
			motor.motorSpeed =-5000f;
		}
	
	}
}
