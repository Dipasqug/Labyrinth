using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    private GUISkin skin;

	// Use this for initialization
    void Start() {
        skin = Resources.Load("GUISkin") as GUISkin;
    }
	
    void OnGUI() {
        const int buttonWidth = 200;
        const int buttonHeight = 100;
        GUI.skin = skin;


        // Hier wird der Button positioniert
        Rect buttonRect = new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (1 * Screen.height / 3) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight
            );

        // Zeichne den Button und Lade Level bei Klick neu
        if (GUI.Button(buttonRect, "Start")) {
            Application.LoadLevel("Labyrinth");
        }
    }
}