using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tyreloading : MonoBehaviour {
	[SerializeField]
	Image tyre;
	float load_value;

	// Use this for initialization
	void Start () {

		tyre = GetComponent<Image> ();
		load_value = tyre.fillAmount;
		tyre.fillAmount = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		load_value = tyre.fillAmount;
		if (load_value != 1) {
		
			tyre.fillAmount += 0.1f * Time.deltaTime;
		}
		else {
		
			Application.LoadLevel ("3-Menu");
		}
	
	}
}
