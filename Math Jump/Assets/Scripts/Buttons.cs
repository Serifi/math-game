using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene("Game");
    }

    public void quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void settin()
    {
        SceneManager.LoadScene("Settings");
    }

    public void back()
    {
        SceneManager.LoadScene("Menu");
    }
}