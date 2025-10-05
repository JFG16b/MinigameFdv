using UnityEditor.Build.Content;
using UnityEngine;

public class Pause_Script : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool isPaused = false;
   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void PauseGame()//called when the pause button is pressed
    {
        Time.timeScale = 0f;
        isPaused = true;
        pauseMenuUI.SetActive(true); //display Pause menu
    }
    public void ResumeGame() //called when the pause button is pressed
    {
        Time.timeScale = 1f;
        isPaused = false; //Set singleton to false
        pauseMenuUI.SetActive(false); //hide Pause menu
    }
 
}