using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class coinscollection : MonoBehaviour {

	public int coin=0;
	Text scoretext;

	void Start () {
		scoretext = GameObject.Find ("coins").GetComponent<Text> ();
	}
	

	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D obj){
		if (obj.gameObject.tag == "Coin") {
			Destroy(obj.gameObject);
			coin+=1;
			Debug.Log(coin);
			scoretext.text=coin.ToString();
		}
	}
}
