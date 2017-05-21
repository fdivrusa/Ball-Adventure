using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAudioScript : MonoBehaviour {


    public AudioSource audio;


    //When end detect collision with player, I play the sound
    public void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            audio.Play();
        }
    }
}
