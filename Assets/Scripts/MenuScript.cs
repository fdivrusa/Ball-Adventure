using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    private string lastLevel;

    public void Start()
    {
        lastLevel = PlayerPrefs.GetString("lastLevel");
        if (lastLevel == "" || lastLevel == null)
        {
            lastLevel = "Level1"; //If there is no last level finished, the user plays the first level
        }
    }

    public void LoadLevel() //Load last finished level
    {
        SceneManager.LoadScene(lastLevel);
    }

    public void Settings() //Open the settings menu (Luminiosity and sound)
    {
        SceneManager.LoadScene("Settings");
    }

    public void LevelsSelection() //Launch the levels selection menu
    {
        SceneManager.LoadScene("LevelsSelection");
    }

    public void QuitGame() //Quit the game
    {
        Application.Quit();
    }
}
