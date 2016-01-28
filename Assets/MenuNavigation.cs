using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour {

	public void gotoTankSelection(){
		SceneManager.LoadScene ("TankSelection");
	}

	public void gotoMainMenu(){
		SceneManager.LoadScene("MainMenu");
	}

	public void playGame(){
		SceneManager.LoadScene("Game");
	}
}