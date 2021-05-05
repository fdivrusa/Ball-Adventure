using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{

    public Canvas confirmationCanvas;
    public Canvas settingsCanvas;
    public Canvas informationsCanvas;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //If user press the back button
        {
            SceneManager.LoadScene("Menu"); //Return to menu
        }
    }

    public void Start() //At the beginning, confirmationCanvas and informationsCanvas are disable
    {
        NoReset();
    }

    public void NoReset() //If the user click on NO
    {
        //Enable the settingsCanvas
        settingsCanvas.enabled = true;

        //Disable the confirmationCanvas and informationsCanvas
        confirmationCanvas.enabled = false;
        informationsCanvas.enabled = false;
    }

    public void YesReset() //If user want to reset the game
    {
        PlayerPrefs.SetInt("lastLevel", 3); //The save level is level 1
        SceneManager.LoadScene("Menu"); //We reload the Menu
    }

    public void ClickOnReset() //If user click on resetGame Button
    {
        //Disable settingsCanvas
        settingsCanvas.enabled = false;

        //Enable confirmationVanvas
        confirmationCanvas.enabled = true;
    }

    public void ClicOnAbout() //If user click on the "about" button
    {
        //Disable settingsCanvas
        settingsCanvas.enabled = false;

        //Enable InformationsCanvas
        informationsCanvas.enabled = true;
    }

    public void ClickGreenBtAbout()
    {
        //Disable InformationsCanvas
        informationsCanvas.enabled = false;

        //Enable settingsCanvas
        settingsCanvas.enabled = true;
    }
}
