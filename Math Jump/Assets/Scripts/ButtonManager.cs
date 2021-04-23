using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void quitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}