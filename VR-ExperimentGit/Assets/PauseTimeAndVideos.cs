using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class PauseTimeAndVideos : MonoBehaviour
{
    public VideoPlayer videoPlayer1;
    public VideoPlayer videoPlayer2;
    private Button button;
    private bool isPaused = false;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(PauseResumeTime);
    }

    private void PauseResumeTime()
    {
        if(!isPaused)
        {
            Time.timeScale = 0;
            videoPlayer1.Pause();
            videoPlayer2.Pause();
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1;
            videoPlayer1.Play();
            videoPlayer2.Play();
            isPaused = false;
        }
    }
}