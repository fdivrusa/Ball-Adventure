using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionControl1 : MonoBehaviour
{

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "End") //If the player touch the "end" object, he can play the next level 
        {
            PlayerPrefs.SetInt("lastLevel", 4); //We save that the player finished the firstLevel
            gameObject.SetActive(false);
            Initiate.Fade("level2", Color.black, 0.8f); //Transition for the second level
        }
    }
}
