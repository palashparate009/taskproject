using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    private float startTime;
    private bool isRunning = false;
    float timer;

    void Start()
    {
        StartTimer();
        Invoke("StopTimer", 120f);
    }

    void Update()
    {
        if (isRunning)
        {
            float elapsedTime = Time.time - startTime;
            int minutes = (int)(elapsedTime / 60);
            int seconds = (int)(elapsedTime % 60);
            int milliseconds = (int)((elapsedTime * 100) % 100);

            string timerString = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
            timerText.text = timerString;
        }

    }

    public void StartTimer()
    {
        startTime = Time.time;
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public void ResetTimer()
    {
        startTime = 0f;
        timerText.text = "00:00:00";
    }
}