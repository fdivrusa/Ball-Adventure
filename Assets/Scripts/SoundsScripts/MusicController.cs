using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This Class allow me to not duplicate music in menu when I change scenes

public class MusicController : MonoBehaviour
{
    private static MusicController music;

    private void Awake()
    {

        DontDestroyOnLoad(this.gameObject);

        if (music == null)
        {
            //If not an instance, set yet
            music = this;
        }
        else
        {
            //Else, destroy  it
            Destroy(this.gameObject);
        }
    }
}
