using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControl4 : MonoBehaviour
{

    public GameObject particlesExplosion;

    public void Start()
    {
        particlesExplosion.SetActive(false);
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "End")
        {
            PlayerPrefs.SetInt("lastLevel", 6); //I save the level (Here it's not the next level because there's not)
            gameObject.SetActive(false); //make the player disapear
            Initiate.Fade("Menu", Color.black, 0.8f); //I reload the menu because there is no next level
        }
        else if (collider.gameObject.tag == "GrowBonus") //If the player touch the GrowBonus
        {
            collider.gameObject.SetActive(false); //I disable the Bonus
            gameObject.transform.localScale += new Vector3(1, 1, 1); //I increase the player's scale
        }
        else if(collider.gameObject.tag == "ShrinkBonus")
        {
            collider.gameObject.SetActive(false);
            gameObject.transform.localScale -= new Vector3(1, 1, 1);
        }
    }


    public void OnCollisionEnter(Collision collision) //Collisions with solid object
    {

        if (collision.gameObject.name == "Lava") //If player touch lava : DIE !!
        {
            particlesExplosion.SetActive(true); //I enable my particles
            Instantiate(particlesExplosion, transform.position, transform.rotation); //Instantiation of the explosion
            gameObject.SetActive(false); //I disable my player (because he is dead)
            Initiate.Fade("Level4", Color.red, 0.8f); //Reloading level
        }
    }
}
