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
    public GameObject particlesExplosion;

    //the moving bridge
    public GameObject bridge1;
    public GameObject bridge2;
    public GameObject bridge3;

    public void Start()
    {
        indicator.GetComponent<Renderer>().material.color = Color.red;
        animDoor = door.GetComponent<Animator>();
        particlesExplosion.SetActive(false);
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
            PlayerPrefs.SetInt("lastLevel", 6); //I save the level
            gameObject.SetActive(false); //make the player disapear
            Initiate.Fade("Level4", Color.black, 0.8f);
        }
    }

    public void OnCollisionEnter(Collision collision) //Collisions with solid object
    {

        if (collision.gameObject.name == "Lava") //If player touch lava : DIE !!
        {
            particlesExplosion.SetActive(true); //I enable my particles
            Instantiate(particlesExplosion, transform.position, transform.rotation); //Instantiation of the explosion
            gameObject.SetActive(false); //I disable my player (because he is dead)
            Initiate.Fade("Level3", Color.red, 0.8f); //Reloading level
        }
    }
}
