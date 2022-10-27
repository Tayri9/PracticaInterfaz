using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject logo, buttonGroup, buttonNewGame, buttonLoadGame, buttonOptions, buttonExit, flag;

    private void OnEnable()
    {
        LeanTween.moveLocalY(logo, -353f, 0f);
        //LeanTween.scale(buttonGroup, Vector3.zero, 0f);
        LeanTween.scale(buttonNewGame, Vector3.zero, 0f);
        LeanTween.scale(buttonLoadGame, Vector3.zero, 0f);
        LeanTween.scale(buttonOptions, Vector3.zero, 0f);
        LeanTween.scale(buttonExit, Vector3.zero, 0f);
        LeanTween.scale(flag, Vector3.zero, 0f);
        //LeanTween.moveLocalY(buttonGroup, -495f, 0f);

        LeanTween.moveLocalY(logo, 209.33f, 1.5f).setEaseSpring().setOnComplete(Botones);
        //LeanTween.moveLocalY(buttonGroup, -48.5417f, 1.5f).setEaseSpring();
                
        void Botones()
        {            
            //LeanTween.scale(buttonGroup, Vector3.one, 0f);
            LeanTween.scale(buttonNewGame, Vector3.one, 1f).setEaseSpring().setOnComplete( () =>
            {
                LeanTween.scale(buttonLoadGame, Vector3.one, 1f).setEaseSpring().setOnComplete(() =>
                {
                    LeanTween.scale(buttonOptions, Vector3.one, 1f).setEaseSpring().setOnComplete(() =>
                    {
                        LeanTween.scale(buttonExit, Vector3.one, 1f).setEaseSpring().setOnComplete(() =>
                        {
                            LeanTween.scale(flag, Vector3.one, 1f).setEaseSpring().setOnComplete(Latido);
                        });
                    });
                });
            });
        }

        void Latido()
        {
            LeanTween.scale(logo, Vector3.one, 1f).setEaseSpring().setLoopPingPong();
        }

    }
}
