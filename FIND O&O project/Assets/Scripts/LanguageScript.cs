using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LanguageScript : MonoBehaviour
{
    public string language = "NL";

    public TextMeshProUGUI homeText;

    public string[] textNL;
    public string[] textENG;
    public string[] textDU; 
    public string[] textFR;

    public bool pressed = false;
    
    void Update() 
    {
        if (language == "NL")
        {
            homeText.text = textNL[0];
        }
        else if (language == "ENG") 
        {
            homeText.text = textENG[0];
        }
        else if (language == "DU") 
        {
            homeText.text = textDU[0];
        }
        else if (language == "FR") 
        {
            homeText.text = textFR[0];
        }
    
    }


    public void NL() 
    {
        pressed = true;
        language = "NL";
    }

    public void ENG() 
    {
        pressed = true;
        language = "ENG";
    }

    public void DU() 
    {
        pressed = true;
        language = "DU";
    }

    public void FR() 
    {
        pressed = true;
        language = "FR";
    }

}
