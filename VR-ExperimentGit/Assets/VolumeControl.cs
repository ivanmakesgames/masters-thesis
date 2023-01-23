using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public VideoPlayer videoPlayer1;
    public VideoPlayer videoPlayer2;
    public Slider volumeSlider;

    private void Start()
    {
        volumeSlider.onValueChanged.AddListener(AdjustVolume);
    }

    public void AdjustVolume(float volume)
    {
        videoPlayer1.SetDirectAudioVolume(0, volume);
        videoPlayer2.SetDirectAudioVolume(0, volume);
    }
}