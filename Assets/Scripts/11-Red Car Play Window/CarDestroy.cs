using UnityEngine;
using System.Collections;

public class CarDestroy : MonoBehaviour {

	public Animator anim;
	void Start () {
		
	}
	
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D obj){
		if (obj.gameObject.tag == "Ground"){
			Debug.Log ("Game Over");

			anim.SetTrigger ("carexplosion");
			Application.LoadLevel ("16-Oops You Fall");
			}

	}


	void OnTriggerEnter2D(Collider2D obj){
		if (obj.gameObject.tag == "EndGame") {
		
			Application.LoadLevel ("17-Thanks For Playing");
		}

		if (obj.gameObject.tag == "StripForCameraView") {
			Camera mcam = GameObject.Find ("Main Camera").GetComponent<Camera> ();
			mcam.orthographicSize = 8;
		}
	}
}
