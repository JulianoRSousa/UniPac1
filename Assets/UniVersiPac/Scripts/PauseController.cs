using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public static bool GameIsPaused = false;
    

    void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }


    void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause(); 
            }
        }
    }
}