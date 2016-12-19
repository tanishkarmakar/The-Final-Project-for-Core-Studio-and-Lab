using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameOverTrigger : MonoBehaviour {

	// Use this for initialization
	void OnTriggerExit () {
		SceneManager.LoadScene ("MainMenu");
	}
	

}
