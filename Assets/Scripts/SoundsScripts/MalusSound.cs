using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalusSound : MonoBehaviour
{

    public AudioSource malusSound;

    public void OnTriggerEnter(Collider collide)
    {
        if(collide.name == "Player")
        {
            malusSound.Play();
        }
    }

}
