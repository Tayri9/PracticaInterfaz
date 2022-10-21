using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject logo, buttonGroup, buttonNewGame, buttonLoadGame, buttonOptions, buttonExit;

    private void OnEnable()
    {
        LeanTween.moveLocalY(logo, -353f, 0f);
        LeanTween.moveLocalY(buttonGroup, -495f, 0f);

        LeanTween.moveLocalY(logo, 221.0483f, 1.5f).setEaseSpring();

        
        //LeanTween.moveLocalY(buttonGroup, -48.5417f, 1.5f).setEaseSpring();
    }

}
