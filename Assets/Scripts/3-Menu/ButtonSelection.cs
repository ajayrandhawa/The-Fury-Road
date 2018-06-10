using UnityEngine;
using System.Collections;

public class ButtonSelection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void about_button(){

		Application.LoadLevel ("4-About");
	}

		public void play_button(){

			Application.LoadLevel("5-Select Vehicle");
		}
}
