using UnityEngine;
using System.Collections;

public class BackScreen : MonoBehaviour {


	void Start () {
	
	}
	

	void Update () {
	
	}

	public void back_button(){
	
		Application.LoadLevel ("3-Menu");
	}

	public void Missions(){
		Application.LoadLevel("4-About(Missions)");
	}

	public void Controls(){
		Application.LoadLevel("4-About(Controls)");
	}

	public void Developer(){
		Application.LoadLevel("4-About(Developer)");
	}

	public void Back_to_About(){
		Application.LoadLevel("4-About");
	}
}
