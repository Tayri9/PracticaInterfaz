using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject menu, logo, buttonGroup, flag, textOptions, language, buttonBack;

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        LeanTween.moveLocalY(textOptions, -2000f, 0f);
        LeanTween.moveLocalY(language, -2000f, 0f);
        LeanTween.moveLocalY(buttonBack, -2000f, 0f);

        LeanTween.moveLocalX(logo, -2000f, 0.5f).setEaseInBack();
        LeanTween.moveLocalX(flag, 2000f, 0.5f).setEaseInBack();
        LeanTween.moveLocalX(buttonGroup, -2000f, 0.5f).setEaseInBack().setOnComplete(CanvasOptionsAnimation);
    }

    private void CanvasOptionsAnimation()
    {
        LeanTween.moveLocalY(textOptions, 302f, 0.5f).setEaseSpring();
        LeanTween.moveLocalY(language, -1.9073e-05f, 0.5f).setEaseSpring();
        LeanTween.moveLocalY(buttonBack, -368.56f, 0.5f).setEaseSpring();
        LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 1f, 0.5f);
    }

    private void OnDisable()
    {
        LeanTween.moveLocalX(logo, -674.43f, 0.5f).setEaseOutBack();
        LeanTween.moveLocalX(flag, 895f, 0.5f).setEaseOutBack();
        LeanTween.moveLocalX(buttonGroup, -674.43f, 0.5f).setEaseOutBack();
    }

    public void ButtonOption()
    {
        gameObject.SetActive(true);
    }

    public void ButtonBack()
    {
        LeanTween.moveLocalY(textOptions, -400f, 0.5f).setEaseInBack();
        LeanTween.moveLocalY(language, -400f, 0.5f).setEaseInBack();
        LeanTween.moveLocalY(buttonBack, -700f, 0.5f).setEaseInBack();
        LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0f, 0.7f).setOnComplete(Disable);
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
