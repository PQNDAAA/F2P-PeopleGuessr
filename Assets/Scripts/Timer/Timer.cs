using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float minutes = 0;
    public float seconds = 0;

    public bool TimerIsRunning = false;
    public bool questionsTime = false;

    Text timerTxt;

    void Start()
    { 
      timerTxt = GetComponent<Text>();

      TimerIsRunning = true;
    }

    void Update()
    {
        if (TimerIsRunning)
        {
            if (seconds > 0)
            {
                seconds -= Time.deltaTime;
            }
            else
            {
                if(minutes == 0)
                {
                    TimerIsRunning=false;
                    Debug.Log("Timer is done");
                }
                else
                {
                    minutes -= 1;
                    seconds = 59;
                }
            }
            timerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
