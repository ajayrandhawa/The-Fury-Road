using UnityEngine;
using System.Collections;

public class SelectVehicle : MonoBehaviour {


	void Start () {
	
	}
	
	void Update () {
	
	}

	public void red_car_clicked(){
	
		Application.LoadLevel ("6-Red Car Clicked");
	}

	public void blue_car_clicked(){
		Application.LoadLevel ("7-Blue Car Clicked");
	}

	public void yellow_car_clicked(){
		Application.LoadLevel ("8-Yellow Car Clicked");
	}

	public void monster_truck_clicked(){
		Application.LoadLevel ("9-Monster Truck Clicked");
	}

	public void truck_clicked(){
		Application.LoadLevel ("10-Truck Clicked");
	}

	public void go_back(){
		Application.LoadLevel ("3-Menu");
	}
}
