using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSound : MonoBehaviour
{

    public AudioSource bonusSound;

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            bonusSound.Play();
        }
    }
}
