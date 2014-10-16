using UnityEngine;
using System.Collections;

//attatched to main camera of instructions scene
public class InstructionsMenu : MonoBehaviour {

	public Texture backgroundTexture;
	
	void OnGUI()
	{
		//display background texture for main menu
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height),backgroundTexture);
		GUI.color = Color.red;
		//displays buttons for menu/detects if it is clicked
		if (GUI.Button(new Rect(Screen.width * .45f, Screen.height * .8f, Screen.width *.1f, Screen.height * .1f), "Back"))
		{
			Application.LoadLevel(Application.loadedLevel - 1);
		}
	}
}
