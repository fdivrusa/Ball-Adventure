using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGameObject : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        //At every level, I call this script to destroy the GameObject that I don't want in level
        Destroy(GameObject.Find("Music Source"));
        Destroy(GameObject.Find("DustStorm"));
    }
}
