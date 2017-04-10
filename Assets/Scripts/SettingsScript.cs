using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{

    public Canvas confirmationCanvas;
    public Canvas settingsCanvas;

    public void Awake() //At the beginning, confirmationCanvas is disable
    {
        NoReset();
    }

    public void NoReset() //If the user click on NO
    {
        Debug.Log("Back to the game");

        //Enable the settingsCanvas
        settingsCanvas.enabled = true;

        //Disable the confirmationCanvas
        confirmationCanvas.enabled = false;

    }

    public void YesReset() //If user want to reset the game
    {
        Debug.Log("Reset of the game");

        PlayerPrefs.SetString("lastLevel", ""); //The save level is nothing
        SceneManager.LoadScene("Menu"); //We reload the Menu
    }

    public void ClickReset() //If user click on resetGame Button
    {
        //Disable settingsCanvas
        settingsCanvas.enabled = false;

        //Enable confirmationVanvas
        confirmationCanvas.enabled = true;

    }
}
