using UnityEngine;
using System.Collections;

public class EscapeKey : MonoBehaviour
{
    void OnPauseGame()
    {
        Time.timeScale = 0;
    }


    void OnResumeGame()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        gameObject.transform.Translate(Vector3.down * Time.deltaTime);
        if (Input.GetKey("escape"))
        {
            if (Time.timeScale == 0)
            {
                OnResumeGame();
            }
            else
            {
                OnPauseGame();
            }
        }
    }
}