using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Loading_line : MonoBehaviour {
	[SerializeField]
	Image Redline;
	float Load_Value;

	void Start () {
		Redline = GetComponent<Image> ();
		Load_Value = Redline.fillAmount;
		Redline.fillAmount = 0;	
	}

	void Update () {
		Load_Value = Redline.fillAmount;
		if (Load_Value != 1) {
			Redline.fillAmount +=0.08f * Time.deltaTime;
		}


	}
}
