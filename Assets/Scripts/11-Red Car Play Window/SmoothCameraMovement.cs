using UnityEngine;
using System.Collections;

public class SmoothCameraMovement : MonoBehaviour {

	void Update(){
		if (transform.position.x >= -2000.0f) {
		
			transform.Translate(-0.07f,0,0);
		}

	}

}
