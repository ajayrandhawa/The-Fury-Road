using UnityEngine;
using System.Collections;

public class MineExplosion : MonoBehaviour {

	public Animator anim;
	void Start () {
	
	}

	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D obj){
		if (obj.gameObject.tag == "Mine") {
		

			anim.SetTrigger ("explosion");

		}


	}
}
