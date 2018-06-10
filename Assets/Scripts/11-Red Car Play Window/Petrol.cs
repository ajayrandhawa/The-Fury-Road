using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Petrol : MonoBehaviour {

	[SerializeField]
	Image petrol;
	float load_value;

	void Start () {
		petrol = GetComponent<Image> ();
		load_value = petrol.fillAmount;
		petrol.fillAmount = 1;	
	}
	

	void Update () {
		load_value = petrol.fillAmount;
		if (load_value != 0) {
			petrol.fillAmount -= 0.01f * Time.deltaTime;
		}
		if (load_value == 0) {
			Application.LoadLevel ("16-Oops You Fall");
		}
	}

}
