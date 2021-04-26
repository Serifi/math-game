using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreT;
    public Text highscoreT;

    void Start()
    {
        scoreT.text = "Score: " + Transmitter.scoreT.ToString();
        highscoreT.text = "Highscore: " + PlayerPrefs.GetInt("highscore").ToString();
    }
}
