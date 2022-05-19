using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextManager : MonoBehaviour
{
    public LanguageManager languageManager;
    public DataManager dataManager;

    public string language = "NL";
    
    //Time
    public string time;
    public int day;
    public int month;
    public int year;
    public string monthString;
    public string date;

    public string[] monthNL;
    public string[] monthENG;
    public string[] monthDU;
    public string[] monthFR;
    
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI dateText;

    public string[] textNL;
    public string[] textENG;
    public string[] textDU; 
    public string[] textFR;

    public bool pressed = false;
    
    void Update() 
    {
        LanguageVoid();
        TimeVoid();
    }

    void LanguageVoid() 
    {
        if (language == "NL")
        {
        }
        else if (language == "ENG") 
        {      
        }
        else if (language == "DU") 
        {           
        }
        else if (language == "FR") 
        {            
        }
    }

    void TimeVoid() 
    {
        time = dataManager.time;
        day = dataManager.day;
        month = dataManager.month;
        year = dataManager.year;

        timeText.text = time;
        if (language == "NL") 
        {
            monthString = monthNL[month - 1];
        }
        else if (language == "ENG") 
        {
            monthString = monthENG[month - 1];
        }
        else if (language == "DU") 
        {
            monthString = monthDU[month  - 1];           
        }
        else if (language == "FR") 
        {
            monthString = monthFR[month - 1];            
        }

        date = day + " " + monthString + " " + year;
        dateText.text = date;
    } 
}
