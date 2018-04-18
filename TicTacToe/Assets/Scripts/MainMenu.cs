using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExampleClass : MonoBehaviour {
	void Start() {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
}

public class MainMenu : MonoBehaviour {

	public void PlayGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void QuitGame(){
		Debug.Log ("Quit!");
		Application.Quit ();
	}

}
