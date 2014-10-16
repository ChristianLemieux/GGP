using UnityEngine;
using System.Collections;

//attatched to Main Camera of Main Menu Scene
public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;

	void OnGUI()
	{
		//display background texture for main menu
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height),backgroundTexture);
		GUI.color = Color.red;
		//Displays Play Button and transitions to game when clicked
		if (GUI.Button(new Rect(Screen.width * .45f, Screen.height * .4f, Screen.width *.1f, Screen.height * .1f), "Play Game"))
		{
			Application.LoadLevel(Application.loadedLevel + 2);
		}

		//Displays instructions button and transitions when pressed
		if (GUI.Button(new Rect(Screen.width * .45f, Screen.height * .6f, Screen.width *.1f, Screen.height * .1f), "Instructions"))
		{
			Application.LoadLevel(Application.loadedLevel + 1);
		}
	}

}
