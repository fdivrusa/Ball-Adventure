using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionControl3 : MonoBehaviour
{

    private bool stateDoor = false; //Default : Door is close
    private Animator animDoor; //Door's animator
    public GameObject indicator;
    public GameObject door;
    public ParticleSystem particlesExplosion;

    //the moving bridge
    public GameObject bridge1;
    public GameObject bridge2;
    public GameObject bridge3;



    public void Start()
    {
        indicator.GetComponent<Renderer>().material.color = Color.red;
        animDoor = door.GetComponent<Animator>();
    }


    public void OnTriggerEnter(Collider collider) //Collisions with non-solid Object (I avoid some bugs with the switch by using this function)
    {
        if (collider.gameObject.name == "Switch" && stateDoor == false) //If player on the switch : Door opening
        {
            indicator.GetComponent<Renderer>().material.color = Color.green; //Indicator turns green
            stateDoor = true; //State is true (open)
            animDoor.SetBool("IsOpen", stateDoor); //Launch of the opening animation
        }
        else if (collider.gameObject.name == "Switch" && stateDoor == true) //If player on the switch again : Door closing
        {
            indicator.GetComponent<Renderer>().material.color = Color.red; //Indicator turns red
            stateDoor = false;
            animDoor.SetBool("IsOpen", stateDoor); //Launch of the closing animation 
        }
        else if (collider.gameObject.name == "End")
        {
            PlayerPrefs.SetString("LastLevel", "Level4"); //I save the level
            gameObject.SetActive(false); //make the player disapear
            Invoke("NextLevel", 3); //I wait 3 seconds to lauch the next level
        }
    }

    public void OnCollisionEnter(Collision collision) //Collisions with solid object
    {

        if (collision.gameObject.name == "Lava") //If player touch lava : DIE !!
        {
            Instantiate(particlesExplosion, transform.position, transform.rotation); //Instantiation of the explosion
            gameObject.SetActive(false); //I disable my player (because he is dead)
            Invoke("Restart", 3); //Calling Restart function after 3 seconds (I wait the end of the explosion)
        }
    }

    /* 
     * Function that reload the level
     */
    public void Restart()
    {
        SceneManager.LoadScene("Level3");
    }

    /*
     * Function that load the next level 
     */
    public void NextLevel()
    {
        SceneManager.LoadScene("Level4");
    }
}
