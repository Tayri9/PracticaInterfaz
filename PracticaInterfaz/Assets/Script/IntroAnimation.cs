using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject logo;

    [SerializeField]
    GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        //oculto el logo de manera inmediata
        LeanTween.moveLocalX(logo, -900f, 0f);
        //hago aparecer el logo
        LeanTween.moveLocalX(logo, 1.0014e-05f, 2.5f).setEaseSpring().setOnComplete(Latido);

        //moverlo localmente en ambos ejes
        //LeanTween.moveLocal(logo, new Vector3(600f, 40f, 0f), 2f);
    }

    void Latido()
    {
        LeanTween.scale(logo, Vector3.one, 0.5f).setEaseSpring().setOnComplete( () => {
            LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0.0f, 1.5f).setOnComplete(Desactivar);
        });
    }

    void Desactivar()
    {
        gameObject.SetActive(false);
        menu.SetActive(true);
    }
}
/*
 * rojo
 * #711E00FF
 * 
 * azul
 * #013C78FF
 * 
 * amarillo
 * #CF9924FF
 * 
 * */
