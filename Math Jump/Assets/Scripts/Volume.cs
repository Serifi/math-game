using UnityEngine;

public class Volume : MonoBehaviour
{
    public AudioSource audio;
    private float volume = 1f;

    private void Update()
    {
        audio.volume = volume;
        Transmitter.audioT = audio;
    }

    public void updateVolume(float volumeP)
    {
        volume = volumeP;
    }
}
