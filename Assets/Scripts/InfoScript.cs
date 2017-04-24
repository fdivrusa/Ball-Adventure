using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoScript : MonoBehaviour
{

    public Canvas infoCanvas;
    public GameObject player;

    public void Start()
    {
        player.SetActive(false);
        infoCanvas.enabled = true;
    }

    public void clickOk()
    {
        player.SetActive(true);
        infoCanvas.enabled = false;
    }

}
