using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    private int lastLevel = 0;
    public Canvas endCanvas;
    public Canvas mainCanvas;

    public void Start()
    {
        //I only allowed portrait orientation
        Screen.orientation = ScreenOrientation.Portrait;

        //At the beginning, EndCanvas is disabled
        endCanvas.enabled = false;

        //Saving level
        lastLevel = PlayerPrefs.GetInt("lastLevel"); 

        if (lastLevel == 0)
        {
            lastLevel = 3; //If there is no last level finished, the user plays the first level
            PlayerPrefs.SetInt("lastLevel", lastLevel);
        }

        if(lastLevel == 7)
        {
            //Show endCanvas 
            endCanvas.enabled = true;

            //Hide menu
            mainCanvas.enabled = false; 
        }
    }

    public void clickOnGreen()
    {
        //Show Menu
        mainCanvas.enabled = true;

        //Hide endCanvas
        endCanvas.enabled = false;
    }

    public void LoadLevel() //Load last finished level with a fade
    {
        //I have to do like this beacause I can't get the name of a scene by Index if the scene is not loaded
        string path = SceneUtility.GetScenePathByBuildIndex(lastLevel);
        string lastLevelName = path.Substring(0, path.Length - 6).Substring(path.LastIndexOf('/') + 1);
        Initiate.Fade(lastLevelName, Color.black, 0.8f);
    }

    public void Settings() //Open the settings menu ("reset the game" and "about")
    {
        SceneManager.LoadScene("Settings");
    }

    public void LevelsSelection() //Launch the levels selection menu
    {
        SceneManager.LoadScene("Levels");
    }

    public void QuitGame() //Quit the game
    {
        Application.Quit();
    }
}
