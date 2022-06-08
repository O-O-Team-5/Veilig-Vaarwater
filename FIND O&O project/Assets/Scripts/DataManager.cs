using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DataManager : MonoBehaviour
{
    //Date & Time
    public int hour;
    public int minutes;
    public int day;
    public int month;
    public int year;
    public string time;

    public bool home = true;
    
    void Update() 
    {
        TimeVoid();
    }

    void TimeVoid() 
    {
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        
        day = System.DateTime.Now.Day;
        month = System.DateTime.Now.Month;
        year = System.DateTime.Now.Year;

        if (minutes < 10) 
        {
            time = "" + hour + ":0" + minutes;
        }
        else 
        {
            time = "" + hour + ":" + minutes;
        }
             
    }

    public void ToggleHome() 
    {
        if(home) 
        {
            home = false;
        } 
        else 
        {
            home = true;
        }
    } 
}
