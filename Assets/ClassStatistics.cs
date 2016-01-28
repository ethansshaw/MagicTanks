using UnityEngine;
using System.Collections;

public class ClassStatistics : MonoBehaviour {

	public int attackDamage;
	public int armour;
	public float speed;


	public void Viper(){
		attackDamage = 3;
		speed = 12f;
		armour = 6;
		Debug.Log ("Viper has now been chosen");
	}

	public void Panther(){
		attackDamage = 7;
		speed = 7;
		armour = 7;
		Debug.Log ("Panther has now been chosen");
	}

	public void Eagle(){
		attackDamage = 3;
		speed = 6;
		armour = 12;
		Debug.Log ("Eagle has now been chosen");
	}

	public void Rhino(){
		attackDamage = 12;
		speed = 3;
		armour = 6;
		Debug.Log ("Rhino has now been chosen");
	}

}


