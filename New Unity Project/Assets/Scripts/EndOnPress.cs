using UnityEngine;
using System.Collections;

public class EndOnPress : MonoBehaviour {
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.U)) {
			Application.Quit ();

		}
	}
}