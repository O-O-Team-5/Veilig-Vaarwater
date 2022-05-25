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
    public TextMeshProUGUI welcomeText;

    public string[] textNL;
    public string[] textENG;
    public string[] textDU; 
    public string[] textFR;

    public string[] welcomes;

    public bool pressed = false;
    
    void Update() 
    {
        language = languageManager.language;
        LanguageVoid();
        TimeVoid();
    }

    void LanguageVoid() 
    {
        if (language == "NL")
        {
            welcomeText.text = welcomes[0];
        }
        else if (language == "ENG") 
        {  
            welcomeText.text = welcomes[1];    
        }
        else if (language == "DU") 
        { 
            welcomeText.text = welcomes[2];          
        }
        else if (language == "FR") 
        {
            welcomeText.text = welcomes[3];            
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
