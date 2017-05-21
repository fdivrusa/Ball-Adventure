using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMenuClone : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //I don"t want the music menu and particles in my levels, I destroy them
        DestroyObject(GameObject.Find("Music Menu"));
        DestroyObject(GameObject.Find("DustStorm"));
    }

}
