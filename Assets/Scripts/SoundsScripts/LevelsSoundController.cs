using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This Class allow me to not duplicate music in Levels when I change scenes

public class LevelsSoundController : MonoBehaviour
{
    private static LevelsSoundController levelMusic;

    private void Awake()
    {

        DontDestroyOnLoad(this.gameObject);

        if (levelMusic == null)
        {
            //If not an instance, set yet
            levelMusic = this;
        }
        else
        {
            //Else, destroy  it
            Destroy(this.gameObject);
        }
    }
}

