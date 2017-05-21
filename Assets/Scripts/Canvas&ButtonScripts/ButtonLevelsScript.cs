using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonLevelsScript : MonoBehaviour {

    private string buttonName;

    public void LoadLevel(GameObject button) //I put my button to get his name and loadLevel
    {
        buttonName = button.name;
        Initiate.Fade(buttonName, Color.black, 0.8f);
    }
}
