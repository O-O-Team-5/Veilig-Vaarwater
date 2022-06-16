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
    [Header("----tijd & datum----")]
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
    [Header("----weer----")]
    public string[] weatherNL;
    public string[] weatherENG;
    public string[] weatherDU; 
    public string[] weatherFR;
    public TextMeshProUGUI[] weatherText;
    public int totalWeatherText;

    //Evenementen
    [Header("----evenementen----")]
    public string[] eventNL;
    public string[] eventENG;
    public string[] eventDU;
    public string[] eventFR;
    public TextMeshProUGUI[] eventText;
    public int totalEventText; 

    //Waterveiligheid
    [Header("----waterveiligheid----")]
    public string[] waterNL;
    public string[] waterENG;
    public string[] waterDU;
    public string[] waterFR;
    public TextMeshProUGUI[] waterText;
    public int totalWaterText;

    //OV
    [Header("----OV----")]
    public string[] ovNL;
    public string[] ovENG;
    public string[] ovDU;
    public string[] ovFR;
    public TextMeshProUGUI[] ovText;
    public int totalOvText; 

    //Regels Main
    [Header("----regels----")]
    public string[] regelsMainNL;
    public string[] regelsMainENG;
    public string[] regelsMainDU;
    public string[] regelsMainFR;
    public TextMeshProUGUI[] regelsMainText;
    public int totalRegelsMain;

    //Regels Dieren
    [Header("----regels dieren----")]
    public string[] regelsDierenNL;
    public string[] regelsDierenENG;
    public string[] regelsDierenDU;
    public string[] regelsDierenFR;
    public TextMeshProUGUI[] regelsDierenText;
    public int totalRegelsDier;

    //Regels ZuidDier
    [Header("----zuiderstrand dieren regels----")]
    public string[] regelsZuidDierNL;
    public string[] regelsZuidDierENG;
    public string[] regelsZuidDierDU;
    public string[] regelsZuidDierFR;
    public TextMeshProUGUI[] regelsZuidDierText;
    public int totalZuidDier;

    //Regels NoordDier
    [Header("----noorderstrand dieren regels----")]
    public string[] regelsNoordDierNL;
    public string[] regelsNoordDierENG;
    public string[] regelsNoordDierDU;
    public string[] regelsNoordDierFR;
    public TextMeshProUGUI[] regelsNoordDierText;
    public int totalNoordDier;

    //Naaktstranden
    [Header("----naakstranden regels----")]
    public string[] naaktstrandenNL;
    public string[] naaktstrandenENG;
    public string[] naaktstrandenDU;
    public string[] naaktstrandenFR;
    public TextMeshProUGUI[] naaktstrandenText;
    public int totalNaaktstranden;

    
    //welcomes
    [Header("----welcomes----")]
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
            for (int i = 0; i < totalRegelsMain; i++) 
            {
                regelsMainText[i].text = regelsMainNL[i];
            }
            for (int i = 0; i < totalRegelsDier; i++) 
            {
                regelsDierenText[i].text = regelsDierenNL[i];
            }
            for (int i = 0; i < totalZuidDier; i++) 
            {
                regelsZuidDierText[i].text = regelsZuidDierNL[i];
            }
            for (int i = 0; i < totalNoordDier; i++) 
            {
                regelsNoordDierText[i].text = regelsNoordDierNL[i];
            }
            for (int i = 0; i < totalNaaktstranden; i++) 
            {
                naaktstrandenText[i].text = naaktstrandenNL[i];
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
            for (int i = 0; i < totalRegelsMain; i++) 
            {
                regelsMainText[i].text = regelsMainENG[i];
            }
            for (int i = 0; i < totalRegelsDier; i++) 
            {
                regelsDierenText[i].text = regelsDierenENG[i];
            }
            for (int i = 0; i < totalZuidDier; i++) 
            {
                regelsZuidDierText[i].text = regelsZuidDierENG[i];
            }
            for (int i = 0; i < totalNoordDier; i++) 
            {
                regelsNoordDierText[i].text = regelsNoordDierENG[i];
            }
            for (int i = 0; i < totalNaaktstranden; i++) 
            {
                naaktstrandenText[i].text = naaktstrandenENG[i];
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
            for (int i = 0; i < totalRegelsMain; i++) 
            {
                regelsMainText[i].text = regelsMainDU[i];
            }
            for (int i = 0; i < totalRegelsDier; i++) 
            {
                regelsDierenText[i].text = regelsDierenDU[i];
            }
            for (int i = 0; i < totalZuidDier; i++) 
            {
                regelsZuidDierText[i].text = regelsZuidDierDU[i];
            }
            for (int i = 0; i < totalNoordDier; i++) 
            {
                regelsNoordDierText[i].text = regelsNoordDierDU[i];
            }
            for (int i = 0; i < totalNaaktstranden; i++) 
            {
                naaktstrandenText[i].text = naaktstrandenDU[i];
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
            for (int i = 0; i < totalRegelsMain; i++) 
            {
                regelsMainText[i].text = regelsMainFR[i];
            }
            for (int i = 0; i < totalRegelsDier; i++) 
            {
                regelsDierenText[i].text = regelsDierenFR[i];
            }      
            for (int i = 0; i < totalZuidDier; i++) 
            {
                regelsZuidDierText[i].text = regelsZuidDierFR[i];
            }
            for (int i = 0; i < totalNoordDier; i++) 
            {
                regelsNoordDierText[i].text = regelsNoordDierFR[i];
            }
            for (int i = 0; i < totalNaaktstranden; i++) 
            {
                naaktstrandenText[i].text = naaktstrandenFR[i];
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
