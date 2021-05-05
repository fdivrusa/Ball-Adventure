using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset; //Offset beetween player and camera

    //Variable initialization
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft; //The game is always on landscape mode except for the menu
        Screen.sleepTimeout = SleepTimeout.NeverSleep; //The screen will never turns off
        offset = transform.position - player.transform.position; //Calculating the offset beetween the player and the camera
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset; //I update the position of the camera 
    }
}
