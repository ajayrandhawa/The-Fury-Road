# The-Fury-Road
This is a 2D Game developed in UNITY (Gaming Engine). The main idea behind the game is that you have to drive as long as you can on a road which has no end and has lots of difficulties. There are mountains (Big &amp; Small) in your way which does not allow you to drive smoothly and creates the problem of going out of fuel. Another difficulty includes mines. Mines are placed in your way and when your car hits the mine it will be thrown into the air and you have to balance the car and make stunts and land it safely. Your car will be crashed if its upper part, bumper or step bumper or trunk lids hits the ground. You have to reach as far as you can before going out of fuel. Also you are provided with boost in your way.  The amount of boost is pre-fixed. Taking the boost is the only way to cover a long distance. You are also provided with fuel tanks in your way. Another important part in the game is collection of coins while playing.

# Game View

<img src="Screenshot.gif" >

### Features

- Lots of different vehicles (many different vehicles:truck, car, monster truck, etc.)
- Suspension
- Numerous stages with levels to reach in each
- Scoreboard
- Cool graphics and smooth physics simulation
- Designed to look good on low resolution and high resolution devices
- Mines
- Boosters
- 5+ Levels!
- 5+ Vehicles!
- Fuel
- Coins

### Prerequisites

1. Unity 5.2
2. Mono Develop
3. Windows System

### Installing

1. Download Repo from Github.
2. Extract to folder.
3. Open Project using Unity 5.2.
4. Open Assest/Scenes Folder and Open "Start-Game" Scenes using Unity.
5. Click on Play.
6. Enjoy the Game.

Executeable Version of Game Added in Project "Game" Folder.

# Code

```
//Car Balancing

using UnityEngine;
using System.Collections;

public class CarBalancing : MonoBehaviour {

	public float ForwardRotationSpeed;
	public float BackwardRotationSpeed;
	Rigidbody2D rigidbody2d;


	void Start () {
		rigidbody2d = GetComponent<Rigidbody2D> ();
	}


	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
				rigidbody2d.MoveRotation(rigidbody2d.rotation-ForwardRotationSpeed*Time.fixedDeltaTime);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				rigidbody2d.MoveRotation(rigidbody2d.rotation+BackwardRotationSpeed*Time.fixedDeltaTime);
			}
			
		}

		
}

```

```
//Car Movement, Boost Activated etc.

using UnityEngine;
using System.Collections;

public class CarBalancing : MonoBehaviour {

	public float ForwardRotationSpeed;
	public float BackwardRotationSpeed;
	Rigidbody2D rigidbody2d;


	void Start () {
		rigidbody2d = GetComponent<Rigidbody2D> ();
	}


	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
				rigidbody2d.MoveRotation(rigidbody2d.rotation-ForwardRotationSpeed*Time.fixedDeltaTime);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				rigidbody2d.MoveRotation(rigidbody2d.rotation+BackwardRotationSpeed*Time.fixedDeltaTime);
			}
			
		}

		
}

```

## Version

2.0

## Authors

Ajay Randhawa
, Bhinderjit Singh Kaler
