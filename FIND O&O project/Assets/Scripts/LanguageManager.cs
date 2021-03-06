using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : MonoBehaviour
{
    public string language = "NL";
    public bool pressed = false;
    public bool nl = true;
    public float delay;

    public bool home = true;
    public bool loop = false;

    public DataManager dataManager;

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

    void Update () 
    {
        if (nl && !pressed && !home && loop) 
        {
            nl = false;
            StartCoroutine(changeLanguage());
        }

        home = dataManager.home;
    }

    IEnumerator changeLanguage() 
    {
        yield return new WaitForSeconds(delay);
        language = "ENG";
        yield return new WaitForSeconds(delay);
        language = "DU";
        yield return new WaitForSeconds(delay);
        language = "FR";
        yield return new WaitForSeconds(delay);
        language = "NL";
        nl = true;
    }
}
