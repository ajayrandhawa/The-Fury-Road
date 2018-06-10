using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TyreLoading : MonoBehaviour {
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

			tyre.fillAmount += 0.2f * Time.deltaTime;
		}
		else {

			Application.LoadLevel ("17-Thanks For Playing");
		}

	}
}