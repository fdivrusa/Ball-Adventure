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

    public void LoadLevel(string level) //Load last finished level
    {
        SceneManager.LoadScene(lastLevel);
    }

    public void Settings(string settings) //Open the settings menu (Luminiosity and sound)
    {
        SceneManager.LoadScene(settings);
    }

    public void LevelsSelection(string levelsSelection) //Launch the levels selection menu
    {
        SceneManager.LoadScene(levelsSelection);
    }

    public void QuitGame() //Quit the game
    {
        Application.Quit();
    }
}
