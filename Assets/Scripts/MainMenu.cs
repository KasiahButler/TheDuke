using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    //Sets the playGameIndex to 1 to signify loading of scene 1 based on build manager
    private int playGameIndex = 1;

    //This is what we are going to call when we click on our button
	public void PlayGame()
    {
        SceneManager.LoadScene(playGameIndex);
    }
}
