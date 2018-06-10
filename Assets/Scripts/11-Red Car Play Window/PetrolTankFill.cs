using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PetrolTankFill : MonoBehaviour {

	[SerializeField]
	Image petrol;

	void Start () {
	
	}


	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D obj){
		if (obj.gameObject.tag == "PetrolTank") {
			petrol.fillAmount += 0.02f;
			Destroy (obj.gameObject);
		}
	}
}
