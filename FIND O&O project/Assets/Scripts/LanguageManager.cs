using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : MonoBehaviour
{
    public string language = "NL";
    public bool pressed = false;

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
