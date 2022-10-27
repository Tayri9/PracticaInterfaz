using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField]
    GameObject menu;

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
        LeanTween.alphaCanvas(menu.GetComponent<CanvasGroup>(), 0f, 1f);
        LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 1f, 1.5f);
    }

    public void ClickButtonOption()
    {
        gameObject.SetActive(true);
    }

    public void ClickButtonBack()
    {

    }
}
