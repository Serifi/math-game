using UnityEngine;

public class Setting : MonoBehaviour
{

    public void SetQuality(int input)
    {
        QualitySettings.SetQualityLevel(input);
    }

    public void setFullscreen(bool input)
    {
        Screen.fullScreen = input;
    }
}
