using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionControl2 : MonoBehaviour {

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "End") //If the player touch the "end" object, he can play the next level 
        {
            PlayerPrefs.SetString("lastLevel", "Level3"); //We save that the player finished the secondLevel
            gameObject.SetActive(false);
            Invoke("NextLevel", 3); //Launching next level after 3 seconds
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level3");
    }
}
