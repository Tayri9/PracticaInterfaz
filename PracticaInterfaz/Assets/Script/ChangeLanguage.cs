using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChangeLanguage : MonoBehaviour
{
    int language = 0;
    int langAvailables;
    // Start is called before the first frame update
    private void Start()
    {
        langAvailables = LocalizationSettings.AvailableLocales.Locales.Count;
    }
    void Awakee()
    {
        //Array con los diferentes idiomas que tiene el juego configurado
        //LocalizationSettings.AvailableLocales.Locales
        //Idiomas = {Español, Inglés, Francés, Alemán, Italiano, ...}

        //El idioma que se está utilizando
        //LocalizationSettings.SelectedLocale

        //int idiomaAleatorio = Random.Range(0, 3); //Genero numero aleatorio

        //LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idiomaAleatorio];

        //Total de idiomas
        //langAvailables = LocalizationSettings.AvailableLocales.Locales.Count;        
    }    
    public void NextLanguage()
    {        
        language += 1;
        if (language >= langAvailables)
        {
            language = 0;
        }
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[language]; 
    }

    public void PreviousLanguage()
    {
        if (language <= 0)
        {
            language = langAvailables;
        }
        language -= 1;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[language];
    }
}
