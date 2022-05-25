using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class DataManager : MonoBehaviour
{
    //Date & Time
    public int hour;
    public int minutes;
    public int day;
    public int month;
    public int year;
    public string time;

    void Start() 
    {
        string url = "https://www.buienradar.nl/weer/Scheveningen/NL/2747599";
        StartCoroutine(Get(url));
    }

    private IEnumerator Get(string url) 
    {
        using (UnityWebRequest uwr = UnityWebRequest.Get(url));
        yield return uwr.SendWebRequest();
    }
    
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

        time = "" + hour + ":" + minutes;      
    }
}
