using UnityEngine;
using System.Collections;

public class CarBalancing : MonoBehaviour {

	public float ForwardRotationSpeed;
	public float BackwardRotationSpeed;
	Rigidbody2D rigidbody2d;


	void Start () {
		rigidbody2d = GetComponent<Rigidbody2D> ();
	}


	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
				rigidbody2d.MoveRotation(rigidbody2d.rotation-ForwardRotationSpeed*Time.fixedDeltaTime);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				rigidbody2d.MoveRotation(rigidbody2d.rotation+BackwardRotationSpeed*Time.fixedDeltaTime);
			}
			
		}

		
}
