using UnityEngine;
using System.Collections;

public class AirMotorOff : MonoBehaviour {
	WheelJoint2D[] wheel;
	JointMotor2D motor;

	void Start () {

		wheel = GameObject.Find("carbody").GetComponents<WheelJoint2D>();
		motor = wheel[0].motor;    //for first tire
		wheel[0].useMotor = false;

		motor = wheel[1].motor; //for second tire
		wheel[1].useMotor = false;

	}
		
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space)){
				motor.motorSpeed=-5000f;
			Debug.Log ("BOOST ACTIVATED");
			}
		}

	void OnCollisionStay2D (Collision2D coll){

		if(coll.gameObject.tag == "Ground"){

			wheel[0].useMotor = true;
			motor.motorSpeed = -2000;

			wheel[1].useMotor = true;
			motor.motorSpeed = -2000;

			if (coll.gameObject.tag == "Boost") {
				
			
				motor.motorSpeed = -5000;


				motor.motorSpeed = -5000;
			}

		}

	}

	void OnCollisionExit2D(Collision2D obj){
		
		if (obj.gameObject.tag == "Ground") {
			wheel [0].useMotor = false;
			wheel [1].useMotor = false;
		}
	}

	void OnTriggerEnter2D(Collider2D obj){
	
		if (obj.gameObject.tag == "Mine") {
			Camera mcam = GameObject.Find ("Main Camera").GetComponent<Camera> ();
			mcam.orthographicSize = 5.8f;
		}
	}

	void OnCollisionEnter2D(Collision2D obj){
		if (obj.gameObject.tag == "Ground") {
			Camera mcam = GameObject.Find ("Main Camera").GetComponent<Camera> ();
			mcam.orthographicSize = 5;
		}
	}

}
