using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFiller : MonoBehaviour
{
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.fillAmount = 0.5f;
    }

    public void Fill(float amount)
    {        
        image.fillAmount += amount;
    }

    /*
    public void rellenar()
    {
        image.fillAmount += 0.1f;
    }
    public void quitar()
    {
        image.fillAmount -= 0.1f;
    }

    */
}
