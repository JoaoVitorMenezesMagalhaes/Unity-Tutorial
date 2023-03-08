using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerCount : MonoBehaviour
{

    public float TimeLeft;
    public bool TimerOn = false;
    public bool complete = false;

    public TextMeshProUGUI TimerText;

    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
        complete = false;
    }

    // Update is called once per frame
    void Update()
    {  
        if(TimerOn) {
            if(TimeLeft > 0) {
                TimeLeft -= Time.deltaTime;
                UpdateTimer(TimeLeft);
                if (complete){
                    TimerOn = false;
                }
            }
            else{
                TimeLeft = 0;
                TimerOn = false;
            }
        }
        
    }

    void UpdateTimer(float currentTime) {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerText.text = string.Format("{0:00}: {1:00}", minutes, seconds);
    }
}
