using UnityEngine;
using System.Collections;

public class TimerScene : MonoBehaviour
{
	bool loadingStarted = true;
	float secondsLeft = 0;

	void Start()
	{
		StartCoroutine(DelayLoadLevel(0));
	}

	IEnumerator DelayLoadLevel(float seconds)
	{
		secondsLeft = seconds;
		loadingStarted = true;
		do
		{
			yield return new WaitForSeconds(300);
		} while (--secondsLeft > 0);

		Application.LoadLevel("MainMenu");
	}
}

	//void OnGUI()
	//{
		//if (loadingStarted)
			//GUI.Label(new Rect(0, 0, 100, 20), secondsLeft.ToString());
	//}
//}