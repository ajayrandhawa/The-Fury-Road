using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Loading_Name_Logo : MonoBehaviour {
	[SerializeField]
	Image Fury_road;
	float Load_Value;

	void Start () {
		Fury_road = GetComponent<Image> ();
		Load_Value = Fury_road.fillAmount;
		Fury_road.fillAmount = 0;	

	}

	void Update () {

		Load_Value = Fury_road.fillAmount;
		if (Load_Value != 1) {

			Fury_road.fillAmount += 0.038f * Time.deltaTime;
		}
		else {

			Application.LoadLevel("2-Loading Screen");
		}

	}
}
