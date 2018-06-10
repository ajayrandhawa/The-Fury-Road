using UnityEngine;
using System.Collections;

public class Boost : MonoBehaviour {


	void Start () {
	
	}
	
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D obj){
		if (obj.gameObject.tag == "Boost") {
			Debug.Log ("Main Boost Activated");
		}
	}
}
