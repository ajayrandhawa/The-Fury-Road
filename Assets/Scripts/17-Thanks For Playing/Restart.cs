using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {


	void Start () {
	
	}
	

	void Update () {
	
	}

	public void change_vehicle(){
	
		Application.LoadLevel("5-Select Vehicle");
	}

	public void quit(){
	
		Application.Quit ();
	}
}
