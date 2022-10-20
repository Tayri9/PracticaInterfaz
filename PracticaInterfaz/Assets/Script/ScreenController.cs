using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScreenController : MonoBehaviour
{
    [SerializeField]
    GameObject screenGame, screenIntro, Player;

    [SerializeField]
    TMP_InputField inputPlayerName;

    [SerializeField]
    TextMeshProUGUI playerName, errorText;

    [SerializeField]
    Slider sliderMusic;

    [SerializeField]
    Toggle toggleMusic;

    // Start is called before the first frame update
    void Start()
    {
        screenGame.SetActive(false);
        screenIntro.SetActive(true);
        Player.SetActive(false);
    }

    public void StartGame()
    {
        

        if (string.IsNullOrEmpty(inputPlayerName.text))
        {
            errorText.text = "Select your username";
        }
        else
        {
            screenGame.SetActive(true);
            screenIntro.SetActive(false);
            Player.SetActive(true);
            Debug.Log(inputPlayerName.text);
            playerName.text = inputPlayerName.text;
        }        
    }
    public void Music()
    {
        
    }
}
