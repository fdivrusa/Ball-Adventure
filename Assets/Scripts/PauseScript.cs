using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{

    public bool isPaused;
    public Canvas pauseCanvas;
    public GameObject player; 

    void Start()
    {
        isPaused = false; //At the beginning, there is no pause
        pauseCanvas.enabled = false; //PauseCanvas is disable at the beginning
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //If user press backButton
        {
            Pause(); //Calling Pause fonction
        }
    }

    public void Pause()
    {
        isPaused = !isPaused; //If user press again backButton, he resume the game 

        if (isPaused)
        {
            player.SetActive(false); //Pause the player(game)
            pauseCanvas.enabled = true; //Enable pauseCanvas
        }
        else if (!isPaused)
        {
            player.SetActive(true); //Resume the game
            pauseCanvas.enabled = false; //Disable PauseCanvas
        }
    }

    public void ClickOnContinue() //If user click on "Continue" button, I resume the game
    {
        player.SetActive(true);
        Pause(); //By calling Pause function, I put isPaused on false;
    }

    public void ClickOnRestart() //If user click on restart, I reload the current scene
    {
        Initiate.Fade(SceneManager.GetActiveScene().name, Color.black, 0.9f);
    }

    public void ReturnMenu() //If user click on return menu, I load the "Menu" scene
    {
        Initiate.Fade("Menu", Color.black, 0.8f);
    }
}
