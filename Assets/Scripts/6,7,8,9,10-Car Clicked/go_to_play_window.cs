using UnityEngine;
using System.Collections;

public class go_to_play_window : MonoBehaviour {


	void Start () {
	}

	void Update () {
	}

	public void red_car_game_window(){
		Application.LoadLevel ("11-Red Car Play Window");
	}

	public void blue_car_game_window(){
		Application.LoadLevel ("12-Blue Car Play Window");
	}

	public void yellow_car_game_window(){
		Application.LoadLevel ("13-Yellow Car Play Window");
	}

	public void monster_truck_game_window(){
		Application.LoadLevel ("14-Monster Truck Play Window");
	}

	public void truck_game_window(){
		Application.LoadLevel ("15-Truck Play Window");
	}



	public void cross_sign(){
		Application.LoadLevel ("5-Select Vehicle");
	}
}
