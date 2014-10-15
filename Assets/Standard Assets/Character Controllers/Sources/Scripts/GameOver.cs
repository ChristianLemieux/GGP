using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public Texture backgroundTexture;
	
	void OnGUI()
	{
		//display background texture for main menu
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height),backgroundTexture);
		
		//Displays Play Button and transitions to game when clicked
		if (GUI.Button(new Rect(Screen.width * .45f, Screen.height * .4f, Screen.width *.1f, Screen.height * .1f), "Play Again?"))
		{
			Application.LoadLevel(Application.loadedLevel - 1);
		}
		
		//Displays instructions button and transitions when pressed
		if (GUI.Button(new Rect(Screen.width * .45f, Screen.height * .55f, Screen.width *.1f, Screen.height * .1f), "Main Menu"))
		{
			Application.LoadLevel(Application.loadedLevel - 3);
		}

		if (GUI.Button(new Rect(Screen.width * .45f, Screen.height * .7f, Screen.width *.1f, Screen.height * .1f), "Quit"))
		{
			UnityEditor.EditorApplication.isPlaying = false;
			Application.Quit();
		}
	}
}
