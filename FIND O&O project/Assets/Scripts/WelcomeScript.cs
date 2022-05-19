using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WelcomeScript : MonoBehaviour
{
    public string[] welcomes;
    public float delay;
    public bool nl = true;
    public TextMeshProUGUI welcomeText;

    public LanguageManager languageManager;
    public string language;
    public bool pressed;

    void Start() 
    {
        welcomeText.text = welcomes[0];
    }
    void Update() 
    {
        pressed = languageManager.pressed;
        language = languageManager.language;

        if (nl && !pressed) 
        {
            nl = false;
            StartCoroutine(changeLanguage());
        }

        if (pressed) 
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

    }

    IEnumerator changeLanguage() 
    {
        yield return new WaitForSeconds(delay);
        welcomeText.text = welcomes[1];
        yield return new WaitForSeconds(delay);
        welcomeText.text = welcomes[2];
        yield return new WaitForSeconds(delay);
        welcomeText.text = welcomes[3];
        yield return new WaitForSeconds(delay);
        welcomeText.text = welcomes[0];
        nl = true;
    }
}
