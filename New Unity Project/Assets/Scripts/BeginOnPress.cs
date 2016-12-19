using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BeginOnPress: MonoBehaviour {

	void Update(){
		if(Input.GetKeyDown(KeyCode.Space )){
			SceneManager.LoadScene ("Test0.1");
		}
	}
}