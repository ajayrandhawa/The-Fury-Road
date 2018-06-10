using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {


	void Start () {
	
	}
	

	void Update () {
	
		Vector3 characterposition = GameObject.Find ("carbody").transform.position;

		this.transform.position = new Vector3 (characterposition.x +5, characterposition.y +1, characterposition.z -10);
	}
}
