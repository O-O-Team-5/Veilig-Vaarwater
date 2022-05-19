using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    //Date & Time
    public int hour;
    public int minutes;
    public int seconds;
    public int day;
    public int month;
    public int year;
    public string time;
    
    void Update() 
    {
        TimeVoid();
    }

    void TimeVoid() 
    {
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        seconds = System.DateTime.Now.Second;
        
        day = System.DateTime.Now.Day;
        month = System.DateTime.Now.Month;
        year = System.DateTime.Now.Year;

        time = "" + hour + ":" + minutes + ":" + seconds;
        
        
    }
}