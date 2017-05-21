using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour
{
    private int level;
    public List<GameObject> buttonList = new List<GameObject>(); //List that contain my buttons


    public void Awake()
    {
        for (level = PlayerPrefs.GetInt("lastLevel") - 1; level > 3; level--) //While my buttonList Index != 3, I display my button (I put -1 because Level5 not exist)
        {

            buttonList[level - 3].SetActive(true); //Displaying my button of finished levels

        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //If user press the back button
        {
            SceneManager.LoadScene("Menu"); //Return to menu
        }
    }
}
