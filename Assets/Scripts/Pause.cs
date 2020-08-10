using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    private Canvas canvas;

    void Awake()
    {
        canvas = GetComponent<Canvas>();  
    }
    public void turnOnCanvas()
    {
        canvas.enabled = true;
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            canvas.enabled = false;
        }
    }
    public void StartOne()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(1);
    } 

    public void Quit()
    {
        Application.Quit();
    }
}
