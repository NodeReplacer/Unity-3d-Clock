using UnityEngine;
using System;

public class Clock : MonoBehaviour {
    const float hoursConversion = -30f, minutesConversion = -6f, secondsConversion = -6f;

    [SerializeField] Transform hoursPivot = default, minutesPivot, secondsPivot;

    void Update () {
        //Debug.Log(DateTime.Now);
        
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f,0f,hoursConversion * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f,0f,minutesConversion * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f,0f,secondsConversion * (float)time.TotalSeconds);

        
    }
}
