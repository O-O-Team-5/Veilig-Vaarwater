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
    
    //weather
    public string[] weatherNL;
    public string[] weatherENG;
    public string[] weatherDU; 
    public string[] weatherFR;
    public TextMeshProUGUI[] weatherText;
    public int totalWeatherText;

    //Evenementen
    public string[] eventNL;
    public string[] eventENG;
    public string[] eventDU;
    public string[] eventFR;
    public TextMeshProUGUI[] eventText;
    public int totalEventText; 

    //Waterveiligheid
    
    public string[] waterNL;
    public string[] waterENG;
    public string[] waterDU;
    public string[] waterFR;
    public TextMeshProUGUI[] waterText;
    public int totalWaterText;

    //OV

    public string[] ovNL;
    public string[] ovENG;
    public string[] ovDU;
    public string[] ovFR;
    public TextMeshProUGUI[] ovText;
    public int totalOvText; 



    public string[] welcomes;
    public TextMeshProUGUI welcomeText;


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

            for (int i = 0; i < totalWeatherText; i++) 
            {
                weatherText[i].text = weatherNL[i];
            }
            for (int i = 0; i < totalEventText; i++) 
            {
                eventText[i].text = eventNL[i];
            }
            for (int i = 0; i < totalWaterText; i++) 
            {
                waterText[i].text = waterNL[i];
            }
            for (int i = 0; i < totalOvText; i++) 
            {
                ovText[i].text = ovNL[i];
            }
        }
        else if (language == "ENG") 
        {  
            welcomeText.text = welcomes[1];
            
            for (int i = 0; i < totalWeatherText; i++) 
            {
                weatherText[i].text = weatherENG[i];
            }
            for (int i = 0; i < totalEventText; i++) 
            {
                eventText[i].text = eventENG[i];
            }
            for (int i = 0; i < totalWaterText; i++) 
            {
                waterText[i].text = waterENG[i];
            }
            for (int i = 0; i < totalOvText; i++) 
            {
                ovText[i].text = ovENG[i];
            }
            
        }
        else if (language == "DU") 
        { 
            welcomeText.text = welcomes[2]; 

            for (int i = 0; i < totalWeatherText; i++) 
            {
                weatherText[i].text = weatherDU[i];
            }
            for (int i = 0; i < totalEventText; i++) 
            {
                eventText[i].text = eventDU[i];
            }
            for (int i = 0; i < totalWaterText; i++) 
            {
                waterText[i].text = waterDU[i];
            }
            for (int i = 0; i < totalOvText; i++) 
            {
                ovText[i].text = ovDU[i];
            }
              
        }
        else if (language == "FR") 
        {
            welcomeText.text = welcomes[3];

            for (int i = 0; i < totalWeatherText; i++) 
            {
                weatherText[i].text = weatherFR[i];
            }
            for (int i = 0; i < totalEventText; i++) 
            {
                eventText[i].text = eventFR[i];
            }
            for (int i = 0; i < totalWaterText; i++) 
            {
                waterText[i].text = waterFR[i];
            }
            for (int i = 0; i < totalOvText; i++) 
            {
                ovText[i].text = ovFR[i];
            }         
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
